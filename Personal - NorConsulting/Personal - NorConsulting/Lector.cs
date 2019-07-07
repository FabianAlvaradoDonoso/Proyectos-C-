using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using System.IO;

namespace Personal___NorConsulting
{
    public partial class Lector : Form
    {
        public Lector()
        {
            InitializeComponent();

            fingerPrint = new FingerprintCore();
            fingerPrint.onStatus += new StatusEventHandler(fingerPrint_onStatus);
            //fingerPrint.onFinger += new FingerEventHandler(fingerPrint_onFinger);
            fingerPrint.onImage += new ImageEventHandler(fingerPrint_onImage);
        }

        private FingerprintCore fingerPrint;
        private GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;

        private void Lector_Load(object sender, EventArgs e)
        {
            fingerPrint.Initialize();
            fingerPrint.CaptureInitialize();
        }

        void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG) fingerPrint.StartCapture(source.ToString()); //Cuando detecta algo
            else fingerPrint.StopCapture(source);
        }

        private void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            rawImage = ie.RawImage;
            SetImage(ie.RawImage.Image);

            ExtractTemplate();
        }


        private delegate void delSetImage(Image img);
        void SetImage(Image img)
        {
            if (this.InvokeRequired) this.Invoke(new delSetImage(SetImage), new object[] { img }); //Cuando se invoca el procedimiento se activa este if
            else
            {
                Bitmap bmp = new Bitmap(img, pbHuella.Width, pbHuella.Height); //Aqui se mide y se pasa al PictureBox
                pbHuella.Image = bmp;
            }
        }

        private void ExtractTemplate()
        {
            if(rawImage != null)
            {
                try
                {
                    _template = null;
                    fingerPrint.Extract(rawImage, ref _template);

                    SetQualityBar(_template.Quality); //Para medir la calidad de la imagen

                    DisplayImage(_template, false);
                }
                catch
                {

                    SetQualityBar(-1);
                }
            }
        }

        delegate void delSetQuality(int quality);
        private void SetQualityBar(int quality)
        {
            if(prgbQuality.InvokeRequired == true)
            {
                this.Invoke(new delSetQuality(SetQualityBar), new object[] { quality });
            }
            else
            {
                switch (quality)
                {
                    case 0:
                        {
                            //prgbQuiality.ProgressBarColor = System.Drawing.Color.LightCoral;
                            prgbQuality.Value = prgbQuality.Maximum / 3;
                        } break;
                    case 1:
                        {
                            //prgbQuiality.ProgressBarColor = System.Drawing.Color.YellowGreen;
                            prgbQuality.Value = (prgbQuality.Maximum / 3) * 2;
                        } break;
                    case 2:
                        {
                            //prgbQuiality.ProgressBarColor = System.Drawing.Color.MediumSeaGreen;
                            prgbQuality.Value = prgbQuality.Maximum;
                        } break;
                    default:
                        {
                            //prgbQuiality.ProgressBarColor = System.Drawing.Color.Gray;
                            prgbQuality.Value = 0;
                        } break;
                }
            }
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify)
        {
            IntPtr hdc = FingerprintCore.GetDC();

            IntPtr image = new IntPtr();

            if (identify)
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
                button1.Enabled = true;
            }
            else
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
                button2.Enabled = true;
            }
            SetImage(Bitmap.FromHbitmap(image));

            FingerprintCore.ReleaseDC(hdc);
        }

        //public void nothasding()
        //{
        //    MemoryStream fingerprintData = new MemoryStream();
        //    //_template.Serialize(fingerprintData);
        //    fingerprintData.Position = 0;
        //    BinaryReader br = new BinaryReader(fingerprintData);
        //    Byte[] bytes = br.ReadBytes((Int32)fingerprintData.Length);
        //}
    }


       
}
