namespace AlarmClock
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.active = new System.Windows.Forms.CheckBox();
            this.periodicity = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(147, 53);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(165, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(157, 53);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(27, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(221, 31);
            this.name.TabIndex = 2;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(27, 219);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(221, 31);
            this.time.TabIndex = 3;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Location = new System.Drawing.Point(32, 298);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(139, 29);
            this.active.TabIndex = 5;
            this.active.Text = "Вкл/Выкл";
            this.active.UseVisualStyleBackColor = true;
            // 
            // periodicity
            // 
            this.periodicity.CheckOnClick = true;
            this.periodicity.FormattingEnabled = true;
            this.periodicity.Items.AddRange(new object[] {
            "Пон",
            "Вт",
            "Ср",
            "Четв",
            "Пятн",
            "Субб",
            "Воскр"});
            this.periodicity.Location = new System.Drawing.Point(278, 112);
            this.periodicity.Name = "periodicity";
            this.periodicity.Size = new System.Drawing.Size(203, 228);
            this.periodicity.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(493, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodicity);
            this.Controls.Add(this.active);
            this.Controls.Add(this.time);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.CheckedListBox periodicity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}