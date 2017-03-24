namespace CoreApp
{
    class Ball
    {
        private float ratio;

        public Ball(float vRatio)
        {
            ratio = vRatio;
        }

        public float Ratio
        {
            get
            {
                return ratio;
            }

            set
            {
                ratio = value;
            }
        }
    }
}
