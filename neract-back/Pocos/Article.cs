using System;
using System.Collections;
using System.Collections.Generic;

namespace neract_back.Pocos
{
    public class Article
    {
      public int Id { get; set; } = -1;
      public DateTime PublishDate { get; set; } = C.InactiveTimestamp;
      public User Author { get; set; } = null;
      public string Title { get; set; } = C.LoremIpsumShort;
      public string Body { get; set; } = C.LoremIpsumLong;
      public List<string> Keywords { get; set; } = new List<string>();
    }
}
