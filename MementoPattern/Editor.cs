namespace MementoPattern
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }

        public override string ToString()
        {
            return "Text Editor {" + "content='" + Content + "'}";
        }
    }
}
