namespace MeteostationClient
{
    partial class StatisticsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHumidityNumber = new System.Windows.Forms.Label();
            this.labelTemperatureNumber = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.measureIndicatorsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labelHint = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.37107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.62893F));
            this.tableLayoutPanel1.Controls.Add(this.labelHumidityNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTemperatureNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTemperature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelHumidity, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.69325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.30675F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelHumidityNumber
            // 
            this.labelHumidityNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHumidityNumber.AutoSize = true;
            this.labelHumidityNumber.Location = new System.Drawing.Point(87, 27);
            this.labelHumidityNumber.Name = "labelHumidityNumber";
            this.labelHumidityNumber.Size = new System.Drawing.Size(257, 13);
            this.labelHumidityNumber.TabIndex = 3;
            // 
            // labelTemperatureNumber
            // 
            this.labelTemperatureNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTemperatureNumber.AutoSize = true;
            this.labelTemperatureNumber.Location = new System.Drawing.Point(87, 4);
            this.labelTemperatureNumber.Name = "labelTemperatureNumber";
            this.labelTemperatureNumber.Size = new System.Drawing.Size(257, 13);
            this.labelTemperatureNumber.TabIndex = 2;
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(3, 4);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(78, 13);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "Temperature";
            // 
            // labelHumidity
            // 
            this.labelHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(3, 27);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(78, 13);
            this.labelHumidity.TabIndex = 1;
            this.labelHumidity.Text = "Humidity";
            // 
            // measureIndicatorsBackgroundWorker
            // 
            this.measureIndicatorsBackgroundWorker.WorkerReportsProgress = true;
            this.measureIndicatorsBackgroundWorker.WorkerSupportsCancellation = true;
            this.measureIndicatorsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.measureIndicatorsBackgroundWorker_DoWork);
            this.measureIndicatorsBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.measureIndicatorsBackgroundWorker_ProgressChanged);
            this.measureIndicatorsBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.measureIndicatorsBackgroundWorker_RunWorkerCompleted);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(13, 53);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(50, 13);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "Info label";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 153);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatisticsForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatisticsForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHumidityNumber;
        private System.Windows.Forms.Label labelTemperatureNumber;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelHumidity;
        private System.ComponentModel.BackgroundWorker measureIndicatorsBackgroundWorker;
        private System.Windows.Forms.Label labelHint;
    }
}

