namespace Test
{
    public class A
    {
        #region Fields

        private B _b;

        private C _c;

        private J _j;

        private D _d;
        
        #endregion
        
        public A(B b, J j)
        {
        }

        public void Initialize()
        {
            var loadedData = _b.LoadData();
            _j.Data = _d.Parse(loadedData);
            _c.SendDataToServer(_j.Data);
        }
    }
}




