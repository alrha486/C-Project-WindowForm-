using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace 병원DB
{
    public partial class Form1 : Form
    {
        public string fileToOpen; // 파일 경로
        WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer(); //객체 생성
        List<string> Playlist = new List<string>(); // 음악파일의 경로가 저장 될 리스트

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 위치
        }

        private void 진료예약_Click(object sender, EventArgs e)
        {
            if (log.Text == "로그인") // 로그인 버튼의 텍스트가 로그인이라면
            {
                MessageBox.Show("로그인 후 이용해주세요");
            }
            else if (log.Text == "로그아웃") // 로그인 버튼의 텍스트가 로그아웃이라면
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void 의사목록_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void 환자목록_Click(object sender, EventArgs e)
        {
            if (log.Text == "로그인") // 텍스트가 로그인이라면 
            {
                MessageBox.Show("로그인 후 이용해주세요");
            }
            else if (log.Text == "로그아웃") 
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)// 재생
        {
            if (fileToOpen != null && fileToOpen.EndsWith(".mp3"))
            {
                wmplayer.URL = fileToOpen; // 음악파일의 URL
                wmplayer.controls.play(); // 해당 음악 파일 재생
                string name = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출
                textBox1.Text = "Playing : " + name; // 텍스트 박스에 재생 중이라고 표시
            }
            else if (fileToOpen == null) // 음악파일의 URL이 비어있다면
            {
                textBox1.Text = "파일이 선택되지 않았습니다.";
            }
            else if (fileToOpen.EndsWith(".mp3"))  // 해당파일의 확장자가 mp3 파일이 아니라면
            {
                textBox1.Text = "파일을 재생할 수 없습니다.";
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog(); // 파일 불러오는 함수호출
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK) //불러온 파일을 지정했다면
            {
                fileToOpen = FD.FileName; // 해당 음악 파일의 URL 
                string name1 = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출              
                if (!fileToOpen.EndsWith(".mp3")) // 해당파일의 확장자가 mp3 파일이 아니라면
                {

                    textBox1.Text = "파일을 재생할 수 없습니다.";
                }
                else
                {
                    textBox1.Text = "리스트 추가 : " + name1; // mp3 파일이라면 파일선택이라고 출력
                    Playlist.Add(fileToOpen);
                    string name = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출
                    listBox1.Items.Add(name);
                }
            }

            //  Playlist.Add(fileToOpen); // 플레이리스트에 추가
        }

        private void pictureBox3_Click(object sender, EventArgs e) //일시 정지
        {
            double position = wmplayer.controls.currentPosition;
            if (wmplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmplayer.controls.pause(); // 음악파일 일시정지 함수
                position = wmplayer.controls.currentPosition; // position = 일시정지 한 순간까지의 진행 시간
                string name = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출
                textBox1.Text = "일시정지 : " + name;
                // pictureBox3.Text = "재생";
            }
            else if (wmplayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                wmplayer.controls.play(); // 멈췄던 파일 다시 재생
                wmplayer.controls.currentPosition = position; // position = 일시정지 한 순간까지의 진행 시간
                string name = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출
                textBox1.Text = "재생 : " + name;
                // button3.Text = "일시정지";
            }
        }
        private string GetNextChoice() //다음 곡 재생 함수
        {
            foreach (string k in Playlist) //플레이리스트 반복
            {
                if (k == fileToOpen) // 재생 중인 파일이 해당파일이랑 일치한다면
                {
                    if (Playlist.IndexOf(k) < Playlist.Count - 1) // 재생 파일의 인덱스가 마지막 곡의 인덱스보다 작다면
                    {
                        return Playlist[Playlist.IndexOf(k) + 1]; // 다음 곡 리턴
                    }
                    else
                    {
                        return Playlist[0];//현재 플레이 중인 곡이 플레이리스트의 마지막이라면 첫 번째 곡 리턴
                    }
                }
            }
            return Playlist[0];
        }
        private string GetPreviousChoice()// 이전 곡 재생 함수
        {
            foreach (string k in Playlist)
            {
                if (k == fileToOpen)
                {
                    if (Playlist.IndexOf(k) < Playlist.Count - 1 && Playlist.IndexOf(k) != 0) // 재생 파일의 인덱스가 마지막 곡의 인덱스보다 작다면
                    {
                        return Playlist[Playlist.IndexOf(k) - 1]; //이전 곡 리턴
                    }
                    else if (Playlist.IndexOf(k) == 0)
                    {
                        return Playlist[Playlist.Count - 1]; //마지막 곡 리턴
                    }
                }
            }
            string t = fileToOpen;
            return Playlist[Playlist.IndexOf(t) - 1]; ; // 마지막 인
        }

        private void pictureBox4_Click(object sender, EventArgs e) // 다음 곡 재생
        {
            if (fileToOpen == null)
            {
                MessageBox.Show("플레이리스트가 비어있습니다.");
            }
            else
            {
                fileToOpen = GetNextChoice(); // 플레이리스트의 첫번 째 파일 
                wmplayer.URL = fileToOpen;
                wmplayer.controls.play(); // 해당 파일 재생
                string name = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출
                textBox1.Text = textBox1.Text = "재생 : " + name;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) // 이전 곡 재생
        {
            if (fileToOpen == null)
            {
                MessageBox.Show("플레이리스트가 비어있습니다.");
            }
            else
            {
                fileToOpen = GetPreviousChoice(); // 플레이리스트의 첫번 째 파일 
                wmplayer.URL = fileToOpen;
                wmplayer.controls.play(); // 해당 파일 재생
                string name = Path.GetFileNameWithoutExtension(fileToOpen); //파일명만 추출
                textBox1.Text = textBox1.Text = "재생 : " + name;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            wmplayer.settings.volume += 10; // 볼륨 업

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            wmplayer.settings.volume -= 10; // 볼륨 다운
        }

        private void pictureBox6_Click(object sender, EventArgs e) // 파일 삭제
        {
            int nIndex = listBox1.SelectedIndex;
            if (nIndex >= 0)
            {
                listBox1.Items.RemoveAt(nIndex); //리스트에서 제거
                Playlist.RemoveAt(nIndex); //플레이리스트에서 제거
            }
            else
            {
                MessageBox.Show("삭제할 파일이 없습니다.", "파일 삭제");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false) 
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            게시판 form6 = new 게시판(this);
            form6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (log.Text == "로그인") // 텍스트가 로그인이라면 form1의 정보를 폼10의 생성자로
            {
                Form10 form10 = new Form10(this);
                form10.ShowDialog();
            }
            else
            {
                if (log.Text == "로그아웃")
                {
                  MessageBox.Show("로그아웃 되었습니다.");
                    log.Text = "로그인";
                    join.Visible = true;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(); // 병원 시간표 폼 생성
            form11.ShowDialog();
        }
    }
    }

    

