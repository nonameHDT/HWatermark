using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

using System.Threading;

namespace HWatermark
{
	public partial class Form1 : Form
	{
		// processing single image?
		private bool processingSingle;
		private int position;

		public Form1()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			processingSingle = true;
			position = 1;
		}


		#region Radio Buttons
		private void rdSingleImage_CheckedChanged(object sender, EventArgs e)
		{
			SwitchMode();
		}

		private void SwitchMode()
		{
			if (rdSingleImage.Checked)
			{
				grboxFolder.Enabled = false;
				grboxSingleImage.Enabled = true;
				processingSingle = true;
			}
			else
			{
				grboxFolder.Enabled = true;
				grboxSingleImage.Enabled = false;
				processingSingle = false;
			}

			chkSubFolder.Enabled = grboxFolder.Enabled;
		}

		/*
		 * Position
		 */
		 
		private void rdTopLeft_Click(object sender, EventArgs e)
		{
			position = 1;
			PreviewPosition();
		}

		private void rdTopCenter_Click(object sender, EventArgs e)
		{
			position = 2;
			PreviewPosition();
		}

		private void rdTopRight_Click(object sender, EventArgs e)
		{
			position = 3;
			PreviewPosition();
		}

		private void rdCenterLeft_Click(object sender, EventArgs e)
		{
			position = 4;
			PreviewPosition();
		}

		private void rdCenter_Click(object sender, EventArgs e)
		{
			position = 5;
			PreviewPosition();
		}

		private void rdCenterRight_Click(object sender, EventArgs e)
		{
			position = 6;
			PreviewPosition();
		}

		private void rdBottomLeft_Click(object sender, EventArgs e)
		{
			position = 7;
			PreviewPosition();
		}

		private void rdBottomCenter_Click(object sender, EventArgs e)
		{
			position = 8;
			PreviewPosition();
		}

		private void rdBottomRight_Click(object sender, EventArgs e)
		{
			position = 9;
			PreviewPosition();
		}

		private void PreviewPosition()
		{
			Bitmap watermark, image;
			if (processingSingle)
			{
				// check if images exists
				if (txtWatermark.Text != "" && File.Exists(txtWatermark.Text) && IsImage(txtWatermark.Text))
				{
					using (var fs = new System.IO.FileStream(txtWatermark.Text, System.IO.FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						watermark = (Bitmap)bmp.Clone();
					}
				}
				else
				{
					return;
				}

				if (txtImage.Text != "" && File.Exists(txtImage.Text) && IsImage(txtImage.Text))
				{
					using (var fs = new System.IO.FileStream(txtImage.Text, System.IO.FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						image = (Bitmap)bmp.Clone();
					}
				}
				else
				{
					return;
				}
			}
			else
			{
				if (txtFolderWatermark.Text != "" && File.Exists(txtFolderWatermark.Text) && IsImage(txtFolderWatermark.Text))
				{
					using (var fs = new System.IO.FileStream(txtFolderWatermark.Text, System.IO.FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						watermark = (Bitmap)bmp.Clone();
					}
				}
				else
				{
					return;
				}

				if (txtFolderFolder.Text != "" && Directory.Exists(txtFolderFolder.Text))
				{
					List<string> files = new List<string>(Directory.GetFiles(txtFolderFolder.Text, "*.*", SearchOption.AllDirectories)
										.Where(s => s.EndsWith(".BMP", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".JPG", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".JPEG", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".PNG", StringComparison.OrdinalIgnoreCase)));

					if (files.Count > 0)
					{
						using (var fs = new System.IO.FileStream(files[0], System.IO.FileMode.Open))
						{
							var bmp = new Bitmap(fs);
							image = (Bitmap)bmp.Clone();
						}
					}
					else
					{
						return;
					}
				}
				else
				{
					return;
				}
			}

			watermark = ResizeWatermark(image, watermark);

			pboxResult.Image = WatermarkImage(image, watermark, CalculatePosition(image, watermark));
		}
		#endregion

		#region Other UI Components

		private void btnStart_Click(object sender, EventArgs e)
		{
			processBar1.Value = 0;
			processBar1.Maximum = 0;
			statusLabel1.Text = "0/0";


			Thread t = new Thread(XuLy);
			t.IsBackground = true;
			t.Start();
		}

		private void XuLy()
		{
			Bitmap watermark, image;

			if (processingSingle)
			{
				// check if images exists
				if (txtWatermark.Text != "" && File.Exists(txtWatermark.Text) && IsImage(txtWatermark.Text))
				{
					using (var fs = new System.IO.FileStream(txtWatermark.Text, System.IO.FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						watermark = (Bitmap)bmp.Clone();
					}
				}
				else
				{
					return;
				}

				if (txtImage.Text != "" && File.Exists(txtImage.Text) && IsImage(txtImage.Text))
				{
					using (var fs = new System.IO.FileStream(txtImage.Text, System.IO.FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						image = (Bitmap)bmp.Clone();
					}
				}
				else
				{
					return;
				}

				watermark = ResizeWatermark(image, watermark);
				WatermarkImage(image, watermark, CalculatePosition(image, watermark)).Save(txtImage.Text);
			}
			else
			{
				if (txtFolderWatermark.Text != "" && File.Exists(txtFolderWatermark.Text) && IsImage(txtFolderWatermark.Text))
				{
					using (var fs = new System.IO.FileStream(txtFolderWatermark.Text, System.IO.FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						watermark = (Bitmap)bmp.Clone();
					}
				}
				else
				{
					return;
				}

				if (txtFolderFolder.Text != "" && Directory.Exists(txtFolderFolder.Text))
				{
					SearchOption sOption = SearchOption.TopDirectoryOnly;
					if (chkSubFolder.Checked)
						sOption = SearchOption.AllDirectories;

					List<string> files = new List<string>(Directory.GetFiles(txtFolderFolder.Text, "*.*", sOption)
										.Where(s => s.EndsWith(".BMP", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".JPG", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".JPEG", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".PNG", StringComparison.OrdinalIgnoreCase)));

					if (files.Count > 0)
					{
						int total = files.Count;
						int count = 0;
						processBar1.Maximum = total;


						foreach (string path in files)
						{
							Bitmap newwater = (Bitmap)watermark.Clone();
							using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								image = (Bitmap)bmp.Clone();
							}

							newwater = ResizeWatermark(image, newwater, path);
							WatermarkImage(image, newwater, CalculatePosition(image, newwater)).Save(path);

							count++;
							processBar1.Value = count;
							statusLabel1.Text = count.ToString() + "/" + total.ToString();
						}
					}
					else
					{
						MessageBox.Show("Can't find any image.", "Error");
						return;
					}
				}
				else
				{
					return;
				}
			}
		}

		#region Single Image
		private void btnBrowseWatermark_Click(object sender, EventArgs e)
		{
			dlgFile.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG";
			DialogResult result = dlgFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtWatermark.Text = dlgFile.FileName;
			}
		}

		private void btnBrowseImage_Click(object sender, EventArgs e)
		{
			dlgFile.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG";
			DialogResult result = dlgFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtImage.Text = dlgFile.FileName;
			}
		}
		#endregion

		#region Folder
		private void btnFolderBrowseWatermark_Click(object sender, EventArgs e)
		{
			dlgFile.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG";
			DialogResult result = dlgFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtFolderWatermark.Text = dlgFile.FileName;
			}
		}

		private void btnFolderBrowseFolder_Click(object sender, EventArgs e)
		{
			DialogResult result = dlgFolder.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtFolderFolder.Text = dlgFolder.SelectedPath;
			}
		}
		#endregion

		#endregion

		#region Processing
		private Bitmap WatermarkImage(Image img, Image watermark, Point p)
		{
			// convert watermark to PNG
			Bitmap waterPNG = new Bitmap(watermark.Width, watermark.Height, PixelFormat.Format32bppArgb);
			Graphics g1 = Graphics.FromImage(waterPNG);
			g1.DrawImage(watermark, 0, 0);

			// draw watermark to Image
			Bitmap resultImage = new Bitmap(img);
			Graphics g2 = Graphics.FromImage(resultImage);
			g2.DrawImage(waterPNG, p);

			return resultImage;
		}

		private Bitmap ResizeWatermark(Image image, Image watermark, string path = "")
		{
			// resize watermark
			int waterOldWidth = watermark.Width;
			int waterNewWidth = image.Width / 6;

			float ratio = (float)((waterNewWidth * 1.0) / waterOldWidth);
			int waterNewHeight = (int)(watermark.Height * ratio);

			int width = waterNewWidth;
			int height = waterNewHeight;
			
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(watermark.HorizontalResolution, watermark.VerticalResolution);

			using (var graphics = Graphics.FromImage(destImage))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (var wrapMode = new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(watermark, destRect, 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}

		private bool IsImage(string filePath)
		{
			using (Stream stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
			{
				stream.Seek(0, SeekOrigin.Begin);

				List<string> jpg = new List<string> { "FF", "D8" };
				List<string> bmp = new List<string> { "42", "4D" };
				List<string> gif = new List<string> { "47", "49", "46" };
				List<string> png = new List<string> { "89", "50", "4E", "47", "0D", "0A", "1A", "0A" };
				List<List<string>> imgTypes = new List<List<string>> { jpg, bmp, gif, png };

				List<string> bytesIterated = new List<string>();

				for (int i = 0; i < 8; i++)
				{
					string bit = stream.ReadByte().ToString("X2");
					bytesIterated.Add(bit);

					bool isImage = imgTypes.Any(img => !img.Except(bytesIterated).Any());
					if (isImage)
					{
						return true;
					}
				}
				return false;
			}
		}

		private Point CalculatePosition(Image image, Image watermark)
		{
			int px = 0, py = 0;
			switch (position)
			{
				case 1:  // top left
					px = image.Width / 5 - watermark.Width / 2;
					py = image.Height / 5 - watermark.Height / 2;
					break;
				case 2:  // top center
					px = (image.Width - watermark.Width) / 2;
					py = image.Height / 5 - watermark.Height / 2;
					break;
				case 3:  // top right
					px = (image.Width / 5) * 4 - watermark.Width / 2;
					py = image.Height / 5 - watermark.Height / 2;
					break;
				case 4:  // center left
					px = image.Width / 5 - watermark.Width / 2;
					py = (image.Height - watermark.Height) / 2;
					break;
				case 5:  // center
					px = (image.Width - watermark.Width) / 2;
					py = (image.Height - watermark.Height) / 2;
					break;
				case 6:  // center right
					px = (image.Width / 5) * 4 - watermark.Width / 2;
					py = (image.Height - watermark.Height) / 2;
					break;
				case 7:  // bottom left
					px = image.Width / 5 - watermark.Width / 2;
					py = image.Height / 5 * 4 - watermark.Height / 2;
					break;
				case 8:  // bottom center
					px = (image.Width - watermark.Width) / 2;
					py = image.Height / 5 * 4 - watermark.Height / 2;
					break;
				case 9:  // bottom right
					px = (image.Width / 5) * 4 - watermark.Width / 2;
					py = image.Height / 5 * 4 - watermark.Height / 2;
					break;
			}

			return new Point(px, py);
		}
		#endregion
	}
}
