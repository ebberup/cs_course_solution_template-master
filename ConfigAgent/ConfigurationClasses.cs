using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigAgent
{
    enum LineTypeEnum
    {
        Comment,
        KeyValue,
        Value,
        ValueValue
    }
    class KeyValueConfig
    {
        private LineTypeEnum lineType;

        public LineTypeEnum LineType
        {
            get { return lineType; }
            set { lineType = value; }
        }

        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string value;

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    class KeyValueConfigContainer
    {
        //TODO: måske skal listen være readonly og objectet selv håndtere ændringer
        public List<KeyValueConfig> LineCollection { get; set; }

        private List<KeyValuePair<string,string>> netto;

        public List<KeyValuePair<string, string>> Properties
        {
            get { return netto; }
        }

        public KeyValueConfigContainer()
        {
            Load();
        }
        private void Load()
        {
            //get file content
            foreach (var item in LineCollection.Where(f => f.LineType==LineTypeEnum.KeyValue))
            {
                netto.Add(new KeyValuePair<string, string>(item.Key, item.Value));
            }
        }
        public void Save() { }
    }
}
