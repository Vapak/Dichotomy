namespace Dichotomy
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.go = new System.Windows.Forms.Button();
            this.fx_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a_TB = new System.Windows.Forms.TextBox();
            this.b_TB = new System.Windows.Forms.TextBox();
            this.e_TB = new System.Windows.Forms.TextBox();
            this.a_label = new System.Windows.Forms.Label();
            this.b_label = new System.Windows.Forms.Label();
            this.e_label = new System.Windows.Forms.Label();
            this.ab_groupBox = new System.Windows.Forms.GroupBox();
            this.e_groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graph = new System.Windows.Forms.Button();
            this.ab_groupBox.SuspendLayout();
            this.e_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.go.FlatAppearance.BorderSize = 0;
            this.go.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go.Location = new System.Drawing.Point(286, 286);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(112, 39);
            this.go.TabIndex = 2;
            this.go.Text = "Посчитать";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // fx_TB
            // 
            this.fx_TB.Location = new System.Drawing.Point(6, 36);
            this.fx_TB.Name = "fx_TB";
            this.fx_TB.Size = new System.Drawing.Size(323, 27);
            this.fx_TB.TabIndex = 3;
            this.fx_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "= 0";
            // 
            // a_TB
            // 
            this.a_TB.Location = new System.Drawing.Point(22, 68);
            this.a_TB.Name = "a_TB";
            this.a_TB.Size = new System.Drawing.Size(79, 27);
            this.a_TB.TabIndex = 6;
            this.a_TB.Text = "-";
            // 
            // b_TB
            // 
            this.b_TB.Location = new System.Drawing.Point(140, 68);
            this.b_TB.Name = "b_TB";
            this.b_TB.Size = new System.Drawing.Size(79, 27);
            this.b_TB.TabIndex = 7;
            this.b_TB.Text = "-";
            // 
            // e_TB
            // 
            this.e_TB.Location = new System.Drawing.Point(6, 68);
            this.e_TB.Name = "e_TB";
            this.e_TB.Size = new System.Drawing.Size(79, 27);
            this.e_TB.TabIndex = 8;
            this.e_TB.Text = "-";
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_label.Location = new System.Drawing.Point(22, 41);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(21, 20);
            this.a_label.TabIndex = 9;
            this.a_label.Text = "a:";
            // 
            // b_label
            // 
            this.b_label.AutoSize = true;
            this.b_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_label.Location = new System.Drawing.Point(136, 42);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(23, 20);
            this.b_label.TabIndex = 10;
            this.b_label.Text = "b:";
            // 
            // e_label
            // 
            this.e_label.AutoSize = true;
            this.e_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_label.Location = new System.Drawing.Point(7, 44);
            this.e_label.Name = "e_label";
            this.e_label.Size = new System.Drawing.Size(22, 20);
            this.e_label.TabIndex = 11;
            this.e_label.Text = "e:";
            // 
            // ab_groupBox
            // 
            this.ab_groupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ab_groupBox.Controls.Add(this.b_TB);
            this.ab_groupBox.Controls.Add(this.a_TB);
            this.ab_groupBox.Controls.Add(this.b_label);
            this.ab_groupBox.Controls.Add(this.a_label);
            this.ab_groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ab_groupBox.Location = new System.Drawing.Point(12, 121);
            this.ab_groupBox.Name = "ab_groupBox";
            this.ab_groupBox.Size = new System.Drawing.Size(240, 108);
            this.ab_groupBox.TabIndex = 12;
            this.ab_groupBox.TabStop = false;
            this.ab_groupBox.Text = "Границы";
            // 
            // e_groupBox
            // 
            this.e_groupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.e_groupBox.Controls.Add(this.e_TB);
            this.e_groupBox.Controls.Add(this.e_label);
            this.e_groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_groupBox.Location = new System.Drawing.Point(268, 121);
            this.e_groupBox.Name = "e_groupBox";
            this.e_groupBox.Size = new System.Drawing.Size(130, 108);
            this.e_groupBox.TabIndex = 14;
            this.e_groupBox.TabStop = false;
            this.e_groupBox.Text = "Точность";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.fx_TB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 81);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уравнение f(x)=0";
            // 
            // graph
            // 
            this.graph.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.graph.FlatAppearance.BorderSize = 0;
            this.graph.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graph.Location = new System.Drawing.Point(12, 286);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(112, 39);
            this.graph.TabIndex = 16;
            this.graph.Text = "График";
            this.graph.UseVisualStyleBackColor = true;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(413, 337);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.e_groupBox);
            this.Controls.Add(this.ab_groupBox);
            this.Controls.Add(this.go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод половинного деления";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.ab_groupBox.ResumeLayout(false);
            this.ab_groupBox.PerformLayout();
            this.e_groupBox.ResumeLayout(false);
            this.e_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox fx_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a_TB;
        private System.Windows.Forms.TextBox b_TB;
        private System.Windows.Forms.TextBox e_TB;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.Label e_label;
        private System.Windows.Forms.GroupBox ab_groupBox;
        private System.Windows.Forms.GroupBox e_groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button graph;
    }
}

