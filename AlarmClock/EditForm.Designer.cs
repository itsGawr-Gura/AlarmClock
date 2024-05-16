namespace AlarmClock
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.active = new System.Windows.Forms.CheckBox();
            this.time = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.periodicity = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(162, 44);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(180, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(139, 44);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Location = new System.Drawing.Point(35, 281);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(139, 29);
            this.active.TabIndex = 9;
            this.active.Text = "Вкл/Выкл";
            this.active.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(24, 198);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(217, 31);
            this.time.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(24, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(217, 31);
            this.name.TabIndex = 6;
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
            this.periodicity.Location = new System.Drawing.Point(284, 82);
            this.periodicity.Name = "periodicity";
            this.periodicity.Size = new System.Drawing.Size(203, 200);
            this.periodicity.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Время";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(558, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodicity);
            this.Controls.Add(this.active);
            this.Controls.Add(this.time);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.CheckedListBox periodicity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}