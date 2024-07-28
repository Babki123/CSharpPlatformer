
using System.ComponentModel;

namespace BasicPlatformGame
{
    partial class Form1
    {
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            Exit = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Player = new PictureBox();
            backGround = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            Coin2 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            ennemyOne = new PictureBox();
            ennemyTwo = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            restartButton = new Button();
            exitButton = new Button();
            endGameText = new TextBox();
            ((ISupportInitialize)Exit).BeginInit();
            ((ISupportInitialize)Player).BeginInit();
            ((ISupportInitialize)backGround).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox9).BeginInit();
            ((ISupportInitialize)pictureBox10).BeginInit();
            ((ISupportInitialize)Coin2).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox11).BeginInit();
            ((ISupportInitialize)pictureBox12).BeginInit();
            ((ISupportInitialize)pictureBox13).BeginInit();
            ((ISupportInitialize)pictureBox14).BeginInit();
            ((ISupportInitialize)pictureBox15).BeginInit();
            ((ISupportInitialize)pictureBox16).BeginInit();
            ((ISupportInitialize)pictureBox17).BeginInit();
            ((ISupportInitialize)pictureBox18).BeginInit();
            ((ISupportInitialize)ennemyOne).BeginInit();
            ((ISupportInitialize)ennemyTwo).BeginInit();
            ((ISupportInitialize)pictureBox21).BeginInit();
            ((ISupportInitialize)pictureBox22).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.Highlight;
            Exit.Location = new Point(12, 37);
            Exit.Name = "Exit";
            Exit.Size = new Size(69, 81);
            Exit.TabIndex = 0;
            Exit.TabStop = false;
            Exit.Tag = "exit";
            Exit.Visible = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Player
            // 
            Player.BackColor = Color.Green;
            Player.Location = new Point(12, 502);
            Player.Name = "Player";
            Player.Size = new Size(42, 52);
            Player.TabIndex = 4;
            Player.TabStop = false;
            Player.Tag = "Player";
            // 
            // backGround
            // 
            backGround.AccessibleRole = AccessibleRole.TitleBar;
            backGround.BackColor = Color.FromArgb(128, 255, 255);
            backGround.Location = new Point(0, 1);
            backGround.Name = "backGround";
            backGround.Size = new Size(628, 579);
            backGround.TabIndex = 5;
            backGround.TabStop = false;
            backGround.Tag = "";
            backGround.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(0, 551);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(628, 29);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "plateform";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Red;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(341, 487);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(264, 30);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "plateform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Red;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(91, 429);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(183, 30);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "plateform";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Red;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(0, 338);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(153, 30);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "plateform";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Red;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(230, 305);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(153, 30);
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "plateform";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Red;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(51, 237);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(80, 30);
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "plateform";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Red;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Location = new Point(216, 160);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(194, 30);
            pictureBox9.TabIndex = 12;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "plateform";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Red;
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox10.Location = new Point(452, 100);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(153, 30);
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "plateform";
            // 
            // Coin2
            // 
            Coin2.BackColor = Color.Yellow;
            Coin2.Location = new Point(430, 439);
            Coin2.Name = "Coin2";
            Coin2.Size = new Size(21, 26);
            Coin2.TabIndex = 14;
            Coin2.TabStop = false;
            Coin2.Tag = "Coin";
            Coin2.SizeChanged += sizeChangedEvent;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Yellow;
            pictureBox2.Location = new Point(470, 439);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 26);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "Coin";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Yellow;
            pictureBox11.Location = new Point(514, 439);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(21, 26);
            pictureBox11.TabIndex = 16;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "Coin";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Yellow;
            pictureBox12.Location = new Point(554, 439);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(21, 26);
            pictureBox12.TabIndex = 17;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "Coin";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Yellow;
            pictureBox13.Location = new Point(246, 273);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(21, 26);
            pictureBox13.TabIndex = 18;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "Coin";
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Yellow;
            pictureBox14.Location = new Point(287, 273);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(21, 26);
            pictureBox14.TabIndex = 19;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "Coin";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Yellow;
            pictureBox15.Location = new Point(328, 273);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(21, 26);
            pictureBox15.TabIndex = 20;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "Coin";
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.Yellow;
            pictureBox16.Location = new Point(485, 59);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(21, 26);
            pictureBox16.TabIndex = 21;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "Coin";
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.Yellow;
            pictureBox17.Location = new Point(523, 59);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(21, 26);
            pictureBox17.TabIndex = 22;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "Coin";
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.Yellow;
            pictureBox18.Location = new Point(563, 59);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(21, 26);
            pictureBox18.TabIndex = 23;
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "Coin";
            // 
            // ennemyOne
            // 
            ennemyOne.BackColor = Color.FromArgb(192, 0, 192);
            ennemyOne.Location = new Point(216, 113);
            ennemyOne.Name = "ennemyOne";
            ennemyOne.Size = new Size(44, 48);
            ennemyOne.TabIndex = 24;
            ennemyOne.TabStop = false;
            ennemyOne.Tag = "ennemy";
            // 
            // ennemyTwo
            // 
            ennemyTwo.BackColor = Color.FromArgb(192, 0, 192);
            ennemyTwo.Location = new Point(91, 385);
            ennemyTwo.Name = "ennemyTwo";
            ennemyTwo.Size = new Size(44, 48);
            ennemyTwo.TabIndex = 25;
            ennemyTwo.TabStop = false;
            ennemyTwo.Tag = "ennemy";
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.Yellow;
            pictureBox21.Location = new Point(389, 439);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(21, 26);
            pictureBox21.TabIndex = 26;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "Coin";
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = Color.Yellow;
            pictureBox22.Location = new Point(341, 439);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(21, 26);
            pictureBox22.TabIndex = 27;
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "Coin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(465, 1);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 28;
            label1.Text = "Score: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 30);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "plateform";
            // 
            // restartButton
            // 
            restartButton.Enabled = false;
            restartButton.Location = new Point(274, 214);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(75, 23);
            restartButton.TabIndex = 30;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Visible = false;
            restartButton.Click += restartButton_Click;
            // 
            // exitButton
            // 
            exitButton.Enabled = false;
            exitButton.Location = new Point(274, 356);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 31;
            exitButton.Text = "Exit Game";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Visible = false;
            exitButton.Click += closeEvent;
            // 
            // endGameText
            // 
            endGameText.BackColor = Color.Cyan;
            endGameText.BorderStyle = BorderStyle.None;
            endGameText.Enabled = false;
            endGameText.Font = new Font("X-Files", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endGameText.Location = new Point(216, 59);
            endGameText.Name = "endGameText";
            endGameText.Size = new Size(194, 30);
            endGameText.TabIndex = 32;
            endGameText.TextAlign = HorizontalAlignment.Center;
            endGameText.Visible = false;
            endGameText.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 576);
            Controls.Add(endGameText);
            Controls.Add(exitButton);
            Controls.Add(restartButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox21);
            Controls.Add(ennemyTwo);
            Controls.Add(ennemyOne);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox2);
            Controls.Add(Coin2);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Player);
            Controls.Add(Exit);
            Controls.Add(backGround);
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyPressed;
            KeyUp += keyReleased;
            ((ISupportInitialize)Exit).EndInit();
            ((ISupportInitialize)Player).EndInit();
            ((ISupportInitialize)backGround).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox9).EndInit();
            ((ISupportInitialize)pictureBox10).EndInit();
            ((ISupportInitialize)Coin2).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox11).EndInit();
            ((ISupportInitialize)pictureBox12).EndInit();
            ((ISupportInitialize)pictureBox13).EndInit();
            ((ISupportInitialize)pictureBox14).EndInit();
            ((ISupportInitialize)pictureBox15).EndInit();
            ((ISupportInitialize)pictureBox16).EndInit();
            ((ISupportInitialize)pictureBox17).EndInit();
            ((ISupportInitialize)pictureBox18).EndInit();
            ((ISupportInitialize)ennemyOne).EndInit();
            ((ISupportInitialize)ennemyTwo).EndInit();
            ((ISupportInitialize)pictureBox21).EndInit();
            ((ISupportInitialize)pictureBox22).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox Exit;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Player;
        private PictureBox backGround;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox Coin2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox ennemyOne;
        private PictureBox ennemyTwo;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private IContainer components;
        private Label label1;
        private PictureBox pictureBox1;
        private Button restartButton;
        private Button exitButton;
        private TextBox endGameText;
    }
}
