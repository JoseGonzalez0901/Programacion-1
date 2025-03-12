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
            Num_destino_txbox = new TextBox();
            Duracion_label = new Label();
            Start = new Button();
            Stop = new Button();
            Registro_de_llamada = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // Num_destino_txbox
            // 
            Num_destino_txbox.Location = new Point(12, 12);
            Num_destino_txbox.Name = "Num_destino_txbox";
            Num_destino_txbox.Size = new Size(223, 23);
            Num_destino_txbox.TabIndex = 0;
            // 
            // Duracion_label
            // 
            Duracion_label.AutoSize = true;
            Duracion_label.Location = new Point(252, 20);
            Duracion_label.Name = "Duracion_label";
            Duracion_label.Size = new Size(38, 15);
            Duracion_label.TabIndex = 1;
            Duracion_label.Text = "label1";
            // 
            // Start
            // 
            Start.Location = new Point(12, 52);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 2;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(107, 52);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 3;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Registro_de_llamada
            // 
            Registro_de_llamada.Location = new Point(379, -2);
            Registro_de_llamada.Name = "Registro_de_llamada";
            Registro_de_llamada.Size = new Size(161, 181);
            Registro_de_llamada.TabIndex = 4;
            Registro_de_llamada.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Location = new Point(197, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "                   ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 180);
            Controls.Add(label1);
            Controls.Add(Registro_de_llamada);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(Duracion_label);
            Controls.Add(Num_destino_txbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num_destino_txbox;
        private Label Duracion_label;
        private Button Start;
        private Button Stop;
        private ListView Registro_de_llamada;
        private Label label1;
    }
}
