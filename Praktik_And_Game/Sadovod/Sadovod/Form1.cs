using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadovod
{
    public partial class AppleCollector : Form
    {
        private PictureBox player;
        private PictureBox apple;
        private Label scoreLabel;
        private int score = 0;

        public AppleCollector()
        {
            InitializeComponent();

            player = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(375, 275), // Центрируем игрока
                Image = Properties.Resources._20,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            apple = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(100, 100), // Положение яблока
                Image = Properties.Resources.add2a861c53f12d,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            scoreLabel = new Label
            {
                Text = "Собрано яблок: 0",
                Location = new Point(10, 10),
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("MonofontoRUS BY Melman", 24, FontStyle.Bold)
            };

            this.Controls.Add(player);
            this.Controls.Add(apple);
            this.Controls.Add(scoreLabel);

            // Обработчик событий клавиатуры
            this.KeyDown += new KeyEventHandler(OnKeyDown);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Перемещение игрока
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.Top -= 10; // Вверх
                    break;
                case Keys.S:
                    player.Top += 10; // Вниз
                    break;
                case Keys.A:
                    player.Left -= 10; // Влево
                    break;
                case Keys.D:
                    player.Left += 10; // Вправо
                    break;
            }

            if (player.Bounds.IntersectsWith(apple.Bounds))
            {
                score++;
                scoreLabel.Text = $"Собрано яблок: {score}";
                MoveApple(); // Перемещение яблока
            }

            this.Invalidate(); // Перерисовка формы
        }
        private void MoveApple()
        {
            Random random = new Random();
            int x = random.Next(0, this.ClientSize.Width - apple.Width);
            int y = random.Next(30, this.ClientSize.Height - apple.Height); // 30 для отступа от верхней части
            apple.Location = new Point(x, y);
        }

        [STAThread]
       // static void Main()
        //{
          //  Application.EnableVisualStyles();
            //Application.Run(new AppleCollector());
        //}
    



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
