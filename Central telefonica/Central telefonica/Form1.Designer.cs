namespace Central_telefonica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            components = new System.ComponentModel.Container();
            Num_origin = new TextBox();
            Duracion_label = new Label();
            Start = new Button();
            Stop = new Button();
            label1 = new Label();
            Num_dest = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Call_duration = new System.Windows.Forms.Timer(components);
            Show_register = new Button();
            SuspendLayout();
            // 
            // Num_origin
            // 
            Num_origin.Location = new Point(12, 12);
            Num_origin.Name = "Num_origin";
            Num_origin.Size = new Size(223, 23);
            Num_origin.TabIndex = 0;
            // 
            // Duracion_label
            // 
            Duracion_label.AutoSize = true;
            Duracion_label.Location = new Point(222, 105);
            Duracion_label.Name = "Duracion_label";
            Duracion_label.Size = new Size(13, 15);
            Duracion_label.TabIndex = 1;
            Duracion_label.Text = "0";
            // 
            // Start
            // 
            Start.Location = new Point(12, 86);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 2;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(107, 86);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 3;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Location = new Point(197, 90);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "                   ";
            // 
            // Num_dest
            // 
            Num_dest.Location = new Point(12, 57);
            Num_dest.Name = "Num_dest";
            Num_dest.Size = new Size(223, 23);
            Num_dest.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 20);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 7;
            label2.Text = "Num origin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 65);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Num dest";
            // 
            // Call_duration
            // 
            Call_duration.Enabled = true;
            Call_duration.Tick += Call_duration_Tick;
            // 
            // Show_register
            // 
            Show_register.Location = new Point(12, 115);
            Show_register.Name = "Show_register";
            Show_register.Size = new Size(75, 23);
            Show_register.TabIndex = 9;
            Show_register.Text = "Register";
            Show_register.UseVisualStyleBackColor = true;
            Show_register.Click += Show_register_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 180);
            Controls.Add(Show_register);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Num_dest);
            Controls.Add(label1);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(Duracion_label);
            Controls.Add(Num_origin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num_origin;
        private Label Duracion_label;
        private Button Start;
        private Button Stop;
        private Label label1;
        private TextBox Num_dest;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer Call_duration;
        private Button Show_register;
    }
}
