using System;
namespace Testik.Models
{
	public class StdAnswer
	{
        public StdAnswer(string caption, int id,
            bool isanswer, bool ischecked)
        {
            Caption = caption;
            Id = id;
            IsAnswer = isanswer;
            IsChecked = ischecked;
        }

        public string Caption { get; set; }
		public int Id { get; set; }
        public bool IsAnswer { get; set; }
        public bool IsChecked { get; set; }
		
	}
}

