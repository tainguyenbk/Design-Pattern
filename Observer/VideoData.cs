using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class VideoData : Subject
    {
        private string _title;
        private string _description;
        private string _filename;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string value)
        {
            _title = value;
            VideoDataChanged();
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            _description = value;
            VideoDataChanged();
        }

        public string GetFileName()
        {
            return _filename;
        }

        public void SetFileName(string value)
        {
            _filename = value;
            VideoDataChanged();
        }

        private void VideoDataChanged()
        {
            NotifyObserver(this, null); // "this" is instance of class VideoData
        }
    }
}
