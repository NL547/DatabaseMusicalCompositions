
namespace MusicCom
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
            this.components = new System.ComponentModel.Container();
            this.носителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCDataSet = new MusicCom.MCDataSet();
            this.журналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.журналTableAdapter = new MusicCom.MCDataSetTableAdapters.ЖурналTableAdapter();
            this.исполнителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнителиTableAdapter = new MusicCom.MCDataSetTableAdapters.ИсполнителиTableAdapter();
            this.носителиTableAdapter = new MusicCom.MCDataSetTableAdapters.НосителиTableAdapter();
            this.произведенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.произведенияTableAdapter = new MusicCom.MCDataSetTableAdapters.ПроизведенияTableAdapter();
            this.стилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стилиTableAdapter = new MusicCom.MCDataSetTableAdapters.СтилиTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableAdapterManager = new MusicCom.MCDataSetTableAdapters.TableAdapterManager();
            this.журналDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнителиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.носителиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.произведенияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стилиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.носителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.произведенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стилиBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.журналDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнителиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.носителиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.произведенияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стилиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // носителиBindingSource
            // 
            this.носителиBindingSource.DataMember = "Носители";
            this.носителиBindingSource.DataSource = this.mCDataSet;
            // 
            // mCDataSet
            // 
            this.mCDataSet.DataSetName = "MCDataSet";
            this.mCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // журналBindingSource
            // 
            this.журналBindingSource.DataMember = "Журнал";
            this.журналBindingSource.DataSource = this.mCDataSet;
            // 
            // журналTableAdapter
            // 
            this.журналTableAdapter.ClearBeforeFill = true;
            // 
            // исполнителиBindingSource
            // 
            this.исполнителиBindingSource.DataMember = "Исполнители";
            this.исполнителиBindingSource.DataSource = this.mCDataSet;
            // 
            // исполнителиTableAdapter
            // 
            this.исполнителиTableAdapter.ClearBeforeFill = true;
            // 
            // носителиTableAdapter
            // 
            this.носителиTableAdapter.ClearBeforeFill = true;
            // 
            // произведенияBindingSource
            // 
            this.произведенияBindingSource.DataMember = "Произведения";
            this.произведенияBindingSource.DataSource = this.mCDataSet;
            // 
            // произведенияTableAdapter
            // 
            this.произведенияTableAdapter.ClearBeforeFill = true;
            // 
            // стилиBindingSource
            // 
            this.стилиBindingSource.DataMember = "Стили";
            this.стилиBindingSource.DataSource = this.mCDataSet;
            // 
            // стилиTableAdapter
            // 
            this.стилиTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.журналDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Журнал";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.исполнителиDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Исполнители";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.носителиDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(745, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Носители";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.произведенияDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(745, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Произведения";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.стилиDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(745, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Стили";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MusicCom.MCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖурналTableAdapter = this.журналTableAdapter;
            this.tableAdapterManager.ИсполнителиTableAdapter = this.исполнителиTableAdapter;
            this.tableAdapterManager.НосителиTableAdapter = this.носителиTableAdapter;
            this.tableAdapterManager.ПроизведенияTableAdapter = this.произведенияTableAdapter;
            this.tableAdapterManager.СтилиTableAdapter = this.стилиTableAdapter;
            // 
            // журналDataGridView
            // 
            this.журналDataGridView.AutoGenerateColumns = false;
            this.журналDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.журналDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.журналDataGridView.DataSource = this.журналBindingSource;
            this.журналDataGridView.Location = new System.Drawing.Point(6, 6);
            this.журналDataGridView.Name = "журналDataGridView";
            this.журналDataGridView.Size = new System.Drawing.Size(733, 388);
            this.журналDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_записи";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_носителя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_носителя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кому_дан";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кому_дан";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_выдачи";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_выдачи";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_возврата";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_возврата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_исполнителя";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код_исполнителя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // исполнителиDataGridView
            // 
            this.исполнителиDataGridView.AutoGenerateColumns = false;
            this.исполнителиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.исполнителиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.исполнителиDataGridView.DataSource = this.исполнителиBindingSource;
            this.исполнителиDataGridView.Location = new System.Drawing.Point(6, 6);
            this.исполнителиDataGridView.Name = "исполнителиDataGridView";
            this.исполнителиDataGridView.Size = new System.Drawing.Size(733, 388);
            this.исполнителиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Код_исполнителя";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код_исполнителя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Исполнитель";
            this.dataGridViewTextBoxColumn8.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Лучшее произведение";
            this.dataGridViewTextBoxColumn9.HeaderText = "Лучшее произведение";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // носителиDataGridView
            // 
            this.носителиDataGridView.AutoGenerateColumns = false;
            this.носителиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.носителиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.носителиDataGridView.DataSource = this.носителиBindingSource;
            this.носителиDataGridView.Location = new System.Drawing.Point(6, 6);
            this.носителиDataGridView.Name = "носителиDataGridView";
            this.носителиDataGridView.Size = new System.Drawing.Size(733, 388);
            this.носителиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Номер_носителя";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер_носителя";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Тип_носителя";
            this.dataGridViewTextBoxColumn11.HeaderText = "Тип_носителя";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Полка";
            this.dataGridViewTextBoxColumn12.HeaderText = "Полка";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // произведенияDataGridView
            // 
            this.произведенияDataGridView.AutoGenerateColumns = false;
            this.произведенияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.произведенияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.произведенияDataGridView.DataSource = this.произведенияBindingSource;
            this.произведенияDataGridView.Location = new System.Drawing.Point(6, 6);
            this.произведенияDataGridView.Name = "произведенияDataGridView";
            this.произведенияDataGridView.Size = new System.Drawing.Size(733, 388);
            this.произведенияDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Номер произведения";
            this.dataGridViewTextBoxColumn13.HeaderText = "Номер произведения";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn14.HeaderText = "Название";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Код_стиля";
            this.dataGridViewTextBoxColumn15.HeaderText = "Код_стиля";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Исполнитель";
            this.dataGridViewTextBoxColumn16.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Альбом";
            this.dataGridViewTextBoxColumn17.HeaderText = "Альбом";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Год";
            this.dataGridViewTextBoxColumn18.HeaderText = "Год";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Номер_носителя";
            this.dataGridViewTextBoxColumn19.HeaderText = "Номер_носителя";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // стилиDataGridView
            // 
            this.стилиDataGridView.AutoGenerateColumns = false;
            this.стилиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.стилиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.стилиDataGridView.DataSource = this.стилиBindingSource;
            this.стилиDataGridView.Location = new System.Drawing.Point(6, 6);
            this.стилиDataGridView.Name = "стилиDataGridView";
            this.стилиDataGridView.Size = new System.Drawing.Size(733, 388);
            this.стилиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Код_стиля";
            this.dataGridViewTextBoxColumn20.HeaderText = "Код_стиля";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Стиль";
            this.dataGridViewTextBoxColumn21.HeaderText = "Стиль";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.носителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.произведенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стилиBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.журналDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнителиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.носителиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.произведенияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стилиDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MCDataSet mCDataSet;
        private System.Windows.Forms.BindingSource журналBindingSource;
        private MCDataSetTableAdapters.ЖурналTableAdapter журналTableAdapter;
        private System.Windows.Forms.BindingSource исполнителиBindingSource;
        private MCDataSetTableAdapters.ИсполнителиTableAdapter исполнителиTableAdapter;
        private System.Windows.Forms.BindingSource носителиBindingSource;
        private MCDataSetTableAdapters.НосителиTableAdapter носителиTableAdapter;
        private System.Windows.Forms.BindingSource произведенияBindingSource;
        private MCDataSetTableAdapters.ПроизведенияTableAdapter произведенияTableAdapter;
        private System.Windows.Forms.BindingSource стилиBindingSource;
        private MCDataSetTableAdapters.СтилиTableAdapter стилиTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView журналDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView исполнителиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView носителиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView произведенияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView стилиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private MCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

