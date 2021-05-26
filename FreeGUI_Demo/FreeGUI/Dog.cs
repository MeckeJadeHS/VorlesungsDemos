namespace FreeGUI
{

    // Die dog Klasse für die Datensätze im Datagrid
    class Dog
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public Dog(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}