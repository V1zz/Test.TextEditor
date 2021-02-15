using TextEditorCore;
using System;

namespace Test.TextEditor
{
    public class MainPresenter
    {
        private readonly IStartForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;

        public MainPresenter(IStartForm view, IFileManager manager, IMessageService messageService)
        {
            //Passing links to the implementation of the interfaces.
            _view = view;
            _manager = manager;
            _messageService = messageService;

            //Reseting the symbol counter
            _view.SetSymbolCount(0);

            //Implement event subscription
            _view.ContentChanged += new EventHandler(_view_ContentChanged);
            _view.FileOpenClick += new EventHandler(_view_FileOpenClick);
            _view.FileSaveClick += _view_FileSaveClick;
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_FileOpenClick(object sender, System.EventArgs e) 
        {
            try
            {
                string filePath = _view.FilePath;
                bool isExist = _manager.IsFileExists(filePath);

                // toDo: зачем?
                if (true)
                {

                }
                

            }
            catch (Exception e)
            {
                _messageService.ShowError(e.Message);
            }
        }

        private void _view_ContentChanged(object sender, System.EventArgs e)
        {
            var content = _view.Content;
            var count = _manager.GetSymbCount(content);
            _view.SetSymbolCount(count);
        }
    } 
}
