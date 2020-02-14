using System;
using System.Collections.Generic;
using System.Text;

namespace NotesOfOrder.Core.Entities
{
    public class ExampleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ExampleSubEntity> ExampleSubEntities { get; set; }
    }
}
