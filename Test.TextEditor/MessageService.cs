using System.Windows.Forms;

namespace Test.TextEditor
{
    /// <summary>
    ///    The "MessageService" class and its "IMessageService" interface are implemented 
    ///  with the aim of displaying (for example, by the Presenter) user messages from anywhere
    ///  in the program to a request from the client side without having access to the code implementation itself.
    /// </summary>

    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamination(string exclamination);
        void ShowWarning(string warning);
        void ShowError(string error);
    }

    public class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(    message 
                              , "Message:"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information  );
        }

        public void ShowExclamination(string exclamination)
        { 
            MessageBox.Show(    exclamination
                              , "Exclamination:"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Exclamation  );
        }

        public void ShowWarning(string warning)
        {
            MessageBox.Show(    warning
                              , "Warning:"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Warning  );
        }

        public void ShowError(string error)
        {
            MessageBox.Show(    error
                              , "!!!ERROR!!!"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Error    );
        }
    }
}
