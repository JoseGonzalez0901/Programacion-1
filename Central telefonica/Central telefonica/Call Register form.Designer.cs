namespace Central_telefonica
{
    partial class Call_Register_form
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
            Register_view = new DataGridView();
            Num_origin_column = new DataGridViewTextBoxColumn();
            Num_dest_column = new DataGridViewTextBoxColumn();
            Duration_column = new DataGridViewTextBoxColumn();
            Price_column = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            Total_llamada_label = new Label();
            label5 = new Label();
            panel2 = new Panel();
            Precio_total_label = new Label();
            label = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Register_view).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Register_view
            // 
            Register_view.AllowUserToOrderColumns = true;
            Register_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Register_view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Register_view.BorderStyle = BorderStyle.None;
            Register_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Register_view.Columns.AddRange(new DataGridViewColumn[] { Num_origin_column, Num_dest_column, Duration_column, Price_column });
            Register_view.Dock = DockStyle.Fill;
            Register_view.GridColor = Color.Gray;
            Register_view.Location = new Point(0, 0);
            Register_view.Name = "Register_view";
            Register_view.ReadOnly = true;
            Register_view.Size = new Size(354, 174);
            Register_view.TabIndex = 0;
            // 
            // Num_origin_column
            // 
            Num_origin_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Num_origin_column.HeaderText = "Num origin";
            Num_origin_column.Name = "Num_origin_column";
            Num_origin_column.ReadOnly = true;
            Num_origin_column.Width = 93;
            // 
            // Num_dest_column
            // 
            Num_dest_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Num_dest_column.HeaderText = "Num dest";
            Num_dest_column.Name = "Num_dest_column";
            Num_dest_column.ReadOnly = true;
            Num_dest_column.Width = 84;
            // 
            // Duration_column
            // 
            Duration_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Duration_column.HeaderText = "Duration";
            Duration_column.Name = "Duration_column";
            Duration_column.ReadOnly = true;
            Duration_column.Width = 78;
            // 
            // Price_column
            // 
            Price_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Price_column.HeaderText = "Price";
            Price_column.Name = "Price_column";
            Price_column.ReadOnly = true;
            Price_column.Width = 58;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 101);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(Total_llamada_label);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 23);
            panel3.TabIndex = 4;
            // 
            // Total_llamada_label
            // 
            Total_llamada_label.AutoSize = true;
            Total_llamada_label.Dock = DockStyle.Left;
            Total_llamada_label.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Total_llamada_label.Location = new Point(70, 0);
            Total_llamada_label.Name = "Total_llamada_label";
            Total_llamada_label.Size = new Size(43, 20);
            Total_llamada_label.TabIndex = 0;
            Total_llamada_label.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "Total calls:";
            // 
            // panel2
            // 
            panel2.Controls.Add(Precio_total_label);
            panel2.Controls.Add(label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 30);
            panel2.TabIndex = 3;
            // 
            // Precio_total_label
            // 
            Precio_total_label.AutoSize = true;
            Precio_total_label.Dock = DockStyle.Left;
            Precio_total_label.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Precio_total_label.Location = new Point(72, 0);
            Precio_total_label.Name = "Precio_total_label";
            Precio_total_label.Size = new Size(43, 20);
            Precio_total_label.TabIndex = 0;
            Precio_total_label.Text = "label1";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = DockStyle.Left;
            label.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(72, 20);
            label.TabIndex = 2;
            label.Text = "Total price:";
            // 
            // panel4
            // 
            panel4.Controls.Add(Register_view);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 174);
            panel4.TabIndex = 2;
            // 
            // Call_Register_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 275);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Call_Register_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Call_Register_form";
            ((System.ComponentModel.ISupportInitialize)Register_view).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Register_view;
        private Panel panel1;
        private Label label2;
        private Label Precio_total_label;
        private DataGridViewTextBoxColumn Num_origin_column;
        private DataGridViewTextBoxColumn Num_dest_column;
        private DataGridViewTextBoxColumn Duration_column;
        private DataGridViewTextBoxColumn Price_column;
        private Panel panel2;
        private Label label;
        private Panel panel3;
        private Label Total_llamada_label;
        private Label label5;
        private Panel panel4;
    }
}