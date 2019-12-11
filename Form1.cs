using OpenCvSharp;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace MyOpenCvProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] ASCII = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };
        private string[] ASCII2 = { "#", "#", "@", "%", "=", "+", "&nbsp;", ":", "-", ".", "&nbsp;" };
        private string ASCII_CONTENT;
        private string ASCII_VIDEO;

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnConvertToAscii_Click(object sender, EventArgs e)
        {
            btnConvertToAscii.Enabled = false;
            try
            {
                Mat image = new Mat(txtPath.Text, ImreadModes.Color);
                image = GetReSizedImage(image, this.trackBar.Value);

                //ũ�Ⱑ ���� �� �̹����� ASCII�� ��ȯ
                ASCII_CONTENT = ConvertToAscii(image);

                // <pre> �±� ���̿� ���� ���ڿ��� ���� ������ ������.
                // ������ ��Ʈ�ѿ� �ε�
                browserMain.DocumentText = "<pre>" + "<Font size=0>" + ASCII_CONTENT + "</Font></pre>";
                btnConvertToAscii.Enabled = true;
            }
            catch
            {
                MessageBox.Show("������ �����ϴ�!");
                return;
            }

        }



        private string ConvertToAscii(Mat image)
        {
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {

                for (int w = 0; w < image.Width; w++)
                {
                    byte b = image.At<Vec3b>(h, w)[0];
                    byte g = image.At<Vec3b>(h, w)[1];
                    byte r = image.At<Vec3b>(h, w)[2];


                    int grayColor = (b + g + r) / 3;

                    //���� ���� ��Ʈ��ġ�� �ּ�ȭ�ϱ����� ��� �÷��׸� ���.
                    if (!toggle)
                    {
                        int index = (grayColor * 10) / 255;
                        sb.Append(ASCII[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }


        private Mat GetReSizedImage(Mat input, int asciiWidth)
        {
            int asciiHeight = 0;
            // �ʺ񿡼� �̹����� ���ο� ���̸� ���
            asciiHeight = (int)Math.Ceiling((double)input.Height * asciiWidth / input.Width);

            //���ο� Mat��ü ���� �� �ػ� ������
            Mat result = new Mat();
            Cv2.Resize(input, result, new OpenCvSharp.Size(asciiWidth, asciiHeight));

            return result;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult diag = openFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (*.txt)|.txt|HTML (*.htm)|.htm";
            DialogResult diag = saveFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    // ������ ������ HTML �� ���
                    // ��� HTML ������ ǥ�� �������� ��ü
                    // HTML������ ������ &nbsp��, �ٹٲ��� \r\n���� ó���ϱ⿡ �װ����� ��ü��Ų��.
                    ASCII_CONTENT = ASCII_CONTENT.Replace("&nbsp;", " ").Replace("<BR>", "\r\n");
                }
                else
                {
                    //���������� �� �� ������ �����ϱ� ���ؼ� <pre> </ pre> �±׸� ���.
                    ASCII_CONTENT = "<pre>" + ASCII_CONTENT + "</pre>";
                }
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(ASCII_CONTENT);
                sw.Flush();
                sw.Close();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("32151183@dankook.ac.kr made by Kim_Chan_Gyeong");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvertToAsciiStructure_Click(object sender, EventArgs e)
        {
            btnConvertToAsciiStructure.Enabled = false;
            try
            {
                Mat image = new Mat(txtPath.Text, ImreadModes.Color);
                image = GetReSizedImage(image, this.trackBar.Value);
                Cv2.CvtColor(image, image, ColorConversionCodes.RGB2GRAY);
                Cv2.Canny(image, image, 150, 200);
                Cv2.BitwiseNot(image, image);
                Cv2.ImShow("input", image);

                //ũ�Ⱑ ���� �� �̹����� ASCII�� ��ȯ

                ASCII_CONTENT = ConvertToAsciiStructure(image);

                // <pre> �±� ���̿� ���� ���ڿ��� ���� ������ ������.
                // ������ ��Ʈ�ѿ� �ε�
                browserMain.DocumentText = "<pre>" + "<Font size=0>" + ASCII_CONTENT + "</Font></pre>";
                btnConvertToAsciiStructure.Enabled = true;
            }
            catch
            {
                MessageBox.Show("������ �����ϴ�!");
                return;
            }

        }
        private string ConvertToAsciiStructure(Mat image)
        {
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {

                for (int w = 0; w < image.Width; w++)
                {
                    byte b = image.At<Vec3b>(h, w)[0];
                    byte g = image.At<Vec3b>(h, w)[1];
                    byte r = image.At<Vec3b>(h, w)[2];


                    int grayColor = (b + g + r) / 3;

                    //���� ���� ��Ʈ��ġ�� �ּ�ȭ�ϱ����� ��� �÷��׸� ���.
                    if (!toggle)
                    {
                        int index = (grayColor * 10) / 255;
                        sb.Append(ASCII2[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VideoCapture capture = new VideoCapture("C:/Users/����Ƽ/Desktop/opencv������/IMG2ASCII_KCG_1/�ȳ��ϻ��.mp4"); // ��Ʈ�Ͽ� ����� ķ�� �̿��Ͽ� �Է��� �޴´�.
                
                Mat frame = new Mat();
               


                Cv2.NamedWindow("�ȳ��ϻ��");
               
                while (capture.PosFrames != capture.FrameCount)
                {
                    capture.Read(frame);
                    while (true)
                    {
                        ASCII_VIDEO = ConvertToAscii(frame);
                        browserMain.DocumentText = "<pre>" + "<Font size=0>" + ASCII_VIDEO + "</Font></pre>";
                        ASCII_VIDEO = null;
                        break;
                    }
                    //Cv2.ImShow("�ȳ��ϻ��", frame);
                    Cv2.WaitKey(33);

                }
                frame.Dispose();
                capture.Release();
                Cv2.DestroyAllWindows();
            }
            catch(Exception en)
            {
                browserMain.DocumentText = en.ToString();
            }

        }
    }
}