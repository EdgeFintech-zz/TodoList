using JsonApiDotNetCore.Internal;
using JsonApiDotNetCore.Models;

namespace TodoListAPI.Models
{
    public class TodoItem : Identifiable
    {
        [Attr("description")]
        public string Description { get; set; }
        public int OwnerId { get; set; }
        [HasOne("person")]
        public virtual Person Owner { get; set; }
    }
}