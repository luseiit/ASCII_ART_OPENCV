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

                //크기가 조정 된 이미지를 ASCII로 변환
                ASCII_CONTENT = ConvertToAscii(image);

                // <pre> 태그 사이에 최종 문자열을 묶어 형식을 유지함.
                // 브라우저 컨트롤에 로드
                browserMain.DocumentText = "<pre>" + "<Font size=0>" + ASCII_CONTENT + "</Font></pre>";
                btnConvertToAscii.Enabled = true;
            }
            catch
            {
                MessageBox.Show("파일이 없습니다!");
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

                    //높이 방향 스트레치를 최소화하기위해 토글 플래그를 사용.
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
            // 너비에서 이미지의 새로운 높이를 계산
            asciiHeight = (int)Math.Ceiling((double)input.Height * asciiWidth / input.Width);

            //새로운 Mat객체 생성 및 해상도 재정의
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
                    // 저장할 형식이 HTML 인 경우
                    // 모든 HTML 공간을 표준 공간으로 교체
                    // HTML에서는 공백을 &nbsp로, 줄바꿈을 \r\n으로 처리하기에 그것으로 대체시킨다.
                    ASCII_CONTENT = ASCII_CONTENT.Replace("&nbsp;", " ").Replace("<BR>", "\r\n");
                }
                else
                {
                    //브라우저에서 볼 때 형식을 유지하기 위해서 <pre> </ pre> 태그를 사용.
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

        private void 만든이ToolStripMenuItem_Click(object sender, EventArgs e)
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

                //크기가 조정 된 이미지를 ASCII로 변환

                ASCII_CONTENT = ConvertToAsciiStructure(image);

                // <pre> 태그 사이에 최종 문자열을 묶어 형식을 유지함.
                // 브라우저 컨트롤에 로드
                browserMain.DocumentText = "<pre>" + "<Font size=0>" + ASCII_CONTENT + "</Font></pre>";
                btnConvertToAsciiStructure.Enabled = true;
            }
            catch
            {
                MessageBox.Show("파일이 없습니다!");
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

                    //높이 방향 스트레치를 최소화하기위해 토글 플래그를 사용.
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
                VideoCapture capture = new VideoCapture("C:/Users/루자티/Desktop/opencv과제들/IMG2ASCII_KCG_1/안녕하살법.mp4"); // 노트북에 연결된 캠을 이용하여 입력을 받는다.
                
                Mat frame = new Mat();
               


                Cv2.NamedWindow("안녕하살법");
               
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
                    //Cv2.ImShow("안녕하살법", frame);
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