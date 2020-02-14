using System;
using System.Collections.Generic;
using System.Text;

namespace NotesOfOrder.Core.Entities
{
    public class ExampleSubEntity
    {
        public int Id { get; set; }
        public int ExampleEntityId { get; set; }
        public ExampleEntity ExampleEntity { get; set; }
        public string Name { get; set; }
    }
}
