namespace Robotics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.robot2Command_TxtBox = new System.Windows.Forms.TextBox();
            this.robot2Location_TxtBox = new System.Windows.Forms.TextBox();
            this.planeSize_TxtBox = new System.Windows.Forms.TextBox();
            this.robot1Location_TxtBox = new System.Windows.Forms.TextBox();
            this.robot1Command_TxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.routing_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // robot2Command_TxtBox
            // 
            this.robot2Command_TxtBox.Location = new System.Drawing.Point(184, 159);
            this.robot2Command_TxtBox.Name = "robot2Command_TxtBox";
            this.robot2Command_TxtBox.Size = new System.Drawing.Size(126, 20);
            this.robot2Command_TxtBox.TabIndex = 0;
            this.robot2Command_TxtBox.Leave += new System.EventHandler(this.robot2Command_TxtBox_Leave);
            // 
            // robot2Location_TxtBox
            // 
            this.robot2Location_TxtBox.Location = new System.Drawing.Point(184, 133);
            this.robot2Location_TxtBox.Name = "robot2Location_TxtBox";
            this.robot2Location_TxtBox.Size = new System.Drawing.Size(126, 20);
            this.robot2Location_TxtBox.TabIndex = 0;
            this.robot2Location_TxtBox.Leave += new System.EventHandler(this.robot2Location_TxtBox_Leave);
            // 
            // planeSize_TxtBox
            // 
            this.planeSize_TxtBox.Location = new System.Drawing.Point(184, 55);
            this.planeSize_TxtBox.Name = "planeSize_TxtBox";
            this.planeSize_TxtBox.Size = new System.Drawing.Size(126, 20);
            this.planeSize_TxtBox.TabIndex = 0;
            this.planeSize_TxtBox.Leave += new System.EventHandler(this.planeSize_TxtBox_Leave);
            // 
            // robot1Location_TxtBox
            // 
            this.robot1Location_TxtBox.Location = new System.Drawing.Point(184, 81);
            this.robot1Location_TxtBox.Name = "robot1Location_TxtBox";
            this.robot1Location_TxtBox.Size = new System.Drawing.Size(126, 20);
            this.robot1Location_TxtBox.TabIndex = 0;
            this.robot1Location_TxtBox.Leave += new System.EventHandler(this.robot1Location_TxtBox_Leave);
            // 
            // robot1Command_TxtBox
            // 
            this.robot1Command_TxtBox.Location = new System.Drawing.Point(184, 107);
            this.robot1Command_TxtBox.Name = "robot1Command_TxtBox";
            this.robot1Command_TxtBox.Size = new System.Drawing.Size(126, 20);
            this.robot1Command_TxtBox.TabIndex = 0;
            this.robot1Command_TxtBox.Leave += new System.EventHandler(this.robot1Command_TxtBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Düzlem Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Robot1 Konumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Robot1 Komut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(70, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Robot2 Konumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(70, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Robot2 Komut";
            // 
            // routing_btn
            // 
            this.routing_btn.Location = new System.Drawing.Point(184, 186);
            this.routing_btn.Name = "routing_btn";
            this.routing_btn.Size = new System.Drawing.Size(126, 41);
            this.routing_btn.TabIndex = 2;
            this.routing_btn.Text = "Yönlendir";
            this.routing_btn.UseVisualStyleBackColor = true;
            this.routing_btn.Click += new System.EventHandler(this.routing_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(328, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Örnek: 2,9 (rakam-virgül-rakam)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(328, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Örnek: 1,6 N (rakam-virgül-rakam-boşluk-yön)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(328, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Örnek: MRLLR (L-M-R büyük harf)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(328, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Örnek: 1,6 N (rakam-virgül-rakam-boşluk-yön)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(328, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Örnek: MRLLR (L-M-R büyük harf)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 301);
            this.Controls.Add(this.routing_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.robot1Command_TxtBox);
            this.Controls.Add(this.robot1Location_TxtBox);
            this.Controls.Add(this.planeSize_TxtBox);
            this.Controls.Add(this.robot2Location_TxtBox);
            this.Controls.Add(this.robot2Command_TxtBox);
            this.Name = "Form1";
            this.Text = "Robotics Routing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox robot2Command_TxtBox;
        private System.Windows.Forms.TextBox robot2Location_TxtBox;
        private System.Windows.Forms.TextBox planeSize_TxtBox;
        private System.Windows.Forms.TextBox robot1Location_TxtBox;
        private System.Windows.Forms.TextBox robot1Command_TxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button routing_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

