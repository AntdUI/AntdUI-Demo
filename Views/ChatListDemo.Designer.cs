namespace AntdUIDemo.Views
{
    partial class ChatListDemo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.header1 = new AntdUI.PageHeader();
            this.panel1 = new AntdUI.Panel();
            this.chatList = new AntdUI.Chat.ChatList();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "气泡聊天列表。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "ChatList 气泡聊天列表";
            this.header1.UseTitleFont = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chatList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 0;
            this.panel1.Shadow = 12;
            this.panel1.Size = new System.Drawing.Size(750, 483);
            this.panel1.TabIndex = 32;
            this.panel1.Text = "panel1";
            // 
            // chatList
            // 
            this.chatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatList.Location = new System.Drawing.Point(12, 12);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(726, 459);
            this.chatList.TabIndex = 0;
            this.chatList.Text = "chatList1";
            // 
            // ChatListDemo
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header1);
            this.Name = "ChatListDemo";
            this.Size = new System.Drawing.Size(750, 557);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.Panel panel1;
        private AntdUI.Chat.ChatList chatList;
    }
}
