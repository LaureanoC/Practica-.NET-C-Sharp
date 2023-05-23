namespace Geometría
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => default;
            set { m_radio = value; }
            
        }

        public double calcularPerimetro()
        {
            return 2 * Math.PI * m_radio;
        }

        public double calcularSuperficie()
        {
            return Math.PI * m_radio * m_radio;
        }
    }
}