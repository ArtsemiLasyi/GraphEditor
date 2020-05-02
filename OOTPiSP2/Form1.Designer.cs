namespace OOTPiSP2
{
    partial class fmMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.cbTool = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.bbPen = new System.Windows.Forms.Button();
            this.bbBrush = new System.Windows.Forms.Button();
            this.cdChooseBrush = new System.Windows.Forms.ColorDialog();
            this.cdChoosePen = new System.Windows.Forms.ColorDialog();
            this.bbClear = new System.Windows.Forms.Button();
            this.bbOpen = new System.Windows.Forms.Button();
            this.bbSave = new System.Windows.Forms.Button();
            this.odOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.bbCancel = new System.Windows.Forms.Button();
            this.bbNewPlugin = new System.Windows.Forms.Button();
            this.cbPlugins = new System.Windows.Forms.ComboBox();
            this.lbPlagins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(957, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.Control;
            this.pbDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDraw.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbDraw.Location = new System.Drawing.Point(276, 0);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(1111, 778);
            this.pbDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDraw.TabIndex = 1;
            this.pbDraw.TabStop = false;
            this.pbDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseClick);
            this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseMove);
            // 
            // cbTool
            // 
            this.cbTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTool.FormattingEnabled = true;
            this.cbTool.Location = new System.Drawing.Point(0, 31);
            this.cbTool.Name = "cbTool";
            this.cbTool.Size = new System.Drawing.Size(270, 28);
            this.cbTool.TabIndex = 2;
            this.cbTool.TextChanged += new System.EventHandler(this.cbTool_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.Location = new System.Drawing.Point(-4, 8);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(114, 20);
            this.lb.TabIndex = 4;
            this.lb.Text = "Инструмент:";
            // 
            // bbPen
            // 
            this.bbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbPen.Location = new System.Drawing.Point(0, 124);
            this.bbPen.Name = "bbPen";
            this.bbPen.Size = new System.Drawing.Size(135, 32);
            this.bbPen.TabIndex = 5;
            this.bbPen.Text = "Цвет контура";
            this.bbPen.UseVisualStyleBackColor = true;
            this.bbPen.Click += new System.EventHandler(this.bbPen_Click);
            // 
            // bbBrush
            // 
            this.bbBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbBrush.Location = new System.Drawing.Point(135, 124);
            this.bbBrush.Name = "bbBrush";
            this.bbBrush.Size = new System.Drawing.Size(135, 32);
            this.bbBrush.TabIndex = 6;
            this.bbBrush.Text = "Цвет заливки";
            this.bbBrush.UseVisualStyleBackColor = true;
            this.bbBrush.Click += new System.EventHandler(this.bbBrush_Click);
            // 
            // bbClear
            // 
            this.bbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbClear.Location = new System.Drawing.Point(0, 162);
            this.bbClear.Name = "bbClear";
            this.bbClear.Size = new System.Drawing.Size(135, 32);
            this.bbClear.TabIndex = 7;
            this.bbClear.Text = "Очистить";
            this.bbClear.UseVisualStyleBackColor = true;
            this.bbClear.Click += new System.EventHandler(this.bbClear_Click);
            // 
            // bbOpen
            // 
            this.bbOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbOpen.Location = new System.Drawing.Point(0, 83);
            this.bbOpen.Name = "bbOpen";
            this.bbOpen.Size = new System.Drawing.Size(135, 32);
            this.bbOpen.TabIndex = 8;
            this.bbOpen.Text = "Открыть";
            this.bbOpen.UseVisualStyleBackColor = true;
            this.bbOpen.Click += new System.EventHandler(this.bbOpen_Click);
            // 
            // bbSave
            // 
            this.bbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbSave.Location = new System.Drawing.Point(135, 83);
            this.bbSave.Name = "bbSave";
            this.bbSave.Size = new System.Drawing.Size(135, 32);
            this.bbSave.TabIndex = 9;
            this.bbSave.Text = "Сохранить";
            this.bbSave.UseVisualStyleBackColor = true;
            this.bbSave.Click += new System.EventHandler(this.bbSave_Click);
            // 
            // odOpenFile
            // 
            this.odOpenFile.Filter = "Graph files|*.gr";
            // 
            // sdSaveFile
            // 
            this.sdSaveFile.Filter = "Graph files|*.gr";
            // 
            // bbCancel
            // 
            this.bbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbCancel.Location = new System.Drawing.Point(135, 162);
            this.bbCancel.Name = "bbCancel";
            this.bbCancel.Size = new System.Drawing.Size(135, 32);
            this.bbCancel.TabIndex = 10;
            this.bbCancel.Text = "Отмена";
            this.bbCancel.UseVisualStyleBackColor = true;
            this.bbCancel.Click += new System.EventHandler(this.bbCancel_Click);
            // 
            // bbNewPlugin
            // 
            this.bbNewPlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbNewPlugin.Location = new System.Drawing.Point(0, 278);
            this.bbNewPlugin.Name = "bbNewPlugin";
            this.bbNewPlugin.Size = new System.Drawing.Size(270, 32);
            this.bbNewPlugin.TabIndex = 11;
            this.bbNewPlugin.Text = "Подключить плагин";
            this.bbNewPlugin.UseVisualStyleBackColor = true;
            // 
            // cbPlugins
            // 
            this.cbPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlugins.FormattingEnabled = true;
            this.cbPlugins.Location = new System.Drawing.Point(0, 244);
            this.cbPlugins.Name = "cbPlugins";
            this.cbPlugins.Size = new System.Drawing.Size(270, 28);
            this.cbPlugins.TabIndex = 12;
            // 
            // lbPlagins
            // 
            this.lbPlagins.AutoSize = true;
            this.lbPlagins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlagins.Location = new System.Drawing.Point(-4, 221);
            this.lbPlagins.Name = "lbPlagins";
            this.lbPlagins.Size = new System.Drawing.Size(87, 20);
            this.lbPlagins.TabIndex = 13;
            this.lbPlagins.Text = "Плагины:";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 778);
            this.Controls.Add(this.lbPlagins);
            this.Controls.Add(this.cbPlugins);
            this.Controls.Add(this.bbNewPlugin);
            this.Controls.Add(this.bbCancel);
            this.Controls.Add(this.bbSave);
            this.Controls.Add(this.bbOpen);
            this.Controls.Add(this.bbClear);
            this.Controls.Add(this.bbBrush);
            this.Controls.Add(this.bbPen);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.cbTool);
            this.Controls.Add(this.pbDraw);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "Лабораторная работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.ComboBox cbTool;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bbPen;
        private System.Windows.Forms.Button bbBrush;
        private System.Windows.Forms.ColorDialog cdChooseBrush;
        private System.Windows.Forms.ColorDialog cdChoosePen;
        private System.Windows.Forms.Button bbClear;
        private System.Windows.Forms.Button bbOpen;
        private System.Windows.Forms.Button bbSave;
        private System.Windows.Forms.OpenFileDialog odOpenFile;
        private System.Windows.Forms.SaveFileDialog sdSaveFile;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.Button bbNewPlugin;
        private System.Windows.Forms.ComboBox cbPlugins;
        private System.Windows.Forms.Label lbPlagins;
    }
}

