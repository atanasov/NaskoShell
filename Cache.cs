using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace NaskoShell
{
    class Cache
    {    // the search hint
        private string hint;
        // list of cached items that are able be found by the search
        List<SearchResult> cached_items;
        // collection of results that match the search hint
        Collection<SearchResult> results;
        private int max_results;

        public int MaxResults
        {
            get
            {
                return max_results;
            }
            set
            {
                max_results = value;
            }
        }

        public Cache()
        {
            cached_items = new List<SearchResult>();
            results = new Collection<SearchResult>();

            // load start menu items
            LoadStartMenu(System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
            LoadStartMenu(System.Environment.GetEnvironmentVariable("PROGRAMDATA") + @"\Microsoft\Windows\Start Menu");
        }

        public string Hint
        {
            get
            {
                return hint;
            }
            set
            {
                hint = value;
                results.Clear();
                foreach (SearchResult sr in cached_items)
                {
                    // really simple case-insensitive substring search. anyone can make this better
                    // and it's not really the point of this tutorial, so we'll go ahead and use it. :)
                    if (sr.Name.ToLower().Contains(hint.ToLower()))
                        results.Add(sr);
                }

               // OnPropertyChanged(new PropertyChangedEventArgs("Hint"));
            }
        }

        public ReadOnlyCollection<SearchResult> Result(string hint)
        {
            results.Clear();
            foreach (SearchResult sr in cached_items)
            {
                // really simple case-insensitive substring search. anyone can make this better
                // and it's not really the point of this tutorial, so we'll go ahead and use it. :)
                if (sr.Name.ToLower().Contains(hint.ToLower()))
                    results.Add(sr);
            }
            return new ReadOnlyCollection<SearchResult>(results);
        }

        public ReadOnlyCollection<SearchResult> Results
        {
            get
            {
                return new ReadOnlyCollection<SearchResult>(results);
            }
        }

        private void LoadStartMenu(string path)
        {
           // IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            foreach (string file in System.IO.Directory.GetFiles(path))
            {
                System.IO.FileInfo fileinfo = new System.IO.FileInfo(file);

                if (fileinfo.Extension.ToLower() == ".lnk")
                {
                   // IWshRuntimeLibrary.WshShortcut link = shell.CreateShortcut(file) as IWshRuntimeLibrary.WshShortcut;
                    SearchResult sr = new SearchResult(fileinfo.Name.Substring(0, fileinfo.Name.Length - 4), file, file);
                    cached_items.Add(sr);
                }
            }

            // recurse through the subfolders
            foreach (string dir in System.IO.Directory.GetDirectories(path))
            {
                LoadStartMenu(dir);
            }
        }

        #region INotifyPropertyChanged Members
      //  public event PropertyChangedEventHandler PropertyChanged;
      //  protected void OnPropertyChanged(PropertyChangedEventArgs e)
      //  {
        //    PropertyChangedEventHandler h = PropertyChanged;
          //  if (h != null)
            //    h(this, e);
       // }
        #endregion
    }
}
