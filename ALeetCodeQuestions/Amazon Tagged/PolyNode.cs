namespace ALQ.Amazon_Tagged
{
    public class PolyNode
    {
        public int Coefficient { get; set; }
        public int Power { get; set; }
        public PolyNode Next { get; set; } = null;

        public PolyNode() { }
        public PolyNode(int x, int y) { this.Coefficient = x; this.Power = y; }
        public PolyNode(int x, int y, PolyNode next) { this.Coefficient = x; this.Power = y; this.Next = next; }
    }

}
