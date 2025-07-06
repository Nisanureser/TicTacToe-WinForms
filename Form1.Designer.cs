using System.Windows.Forms;

namespace ticTacToe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.SuspendLayout();

            // button1
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);

            // button2
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.Location = new System.Drawing.Point(115, 10);
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);

            // button3
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button3.Location = new System.Drawing.Point(220, 10);
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);

            // button4
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button4.Location = new System.Drawing.Point(10, 115);
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);

            // button5
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button5.Location = new System.Drawing.Point(115, 115);
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);

            // button6
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button6.Location = new System.Drawing.Point(220, 115);
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);

            // button7
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button7.Location = new System.Drawing.Point(10, 220);
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);

            // button8
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button8.Location = new System.Drawing.Point(115, 220);
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);

            // button9
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button9.Location = new System.Drawing.Point(220, 220);
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
        }
    }
}
