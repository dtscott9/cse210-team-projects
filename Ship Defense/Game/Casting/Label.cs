namespace Unit06.Game.Casting
{
    /// <summary>
    /// A label to be displayed.
    /// </summary>
    public class Label : Actor
    {
        private Text text;
        private Point position;
        private Point velocity;

        /// <summary>
        /// Constructs a new instance of Label.
        /// </summary>
        public Label(Text text, Point position, Point velocity) : base(false)
        {
            this.text = text;
            this.position = position;
            this.velocity = velocity;
        }

        /// <summary>
        /// Gets the label's text.
        /// </summary>
        /// <returns>The text.</returns>
        public Text GetText()
        {
            return text;
        }

        /// <summary>
        /// Gets the label's position.
        /// </summary>
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return position;
        }

        public void SetPosition(Point position)
        {
            this.position = position;
        }

        public Point GetVelocity()
        {
            return velocity;
        }
        public void SetVelocity(Point velocity)
        {
            this.velocity = velocity;
        }
    }
}