using Azure.Core;

namespace Proyecto_Tienda_Virtual.Models
{
    public class Current_Cart
    {
       public static List<CarryoutViewModel> Cart { get; set; }
        public Carryout Base_cart { get; set; }
        public Current_Cart(Carryout Cart)
        {
            ADD_Item(Cart);
        }
        public Current_Cart()
        {
            if (Cart == null)
            {
                Cart = new List<CarryoutViewModel>();
            }
        }
       public List<Carryout> Get_current_cart(string ID)
        {
            if (Cart.Any(c => c.carryoutList.Any(co => co.Current_ID == ID)))
            {
                // Encontramos el índice del contenedor (en Cart) que contiene ese carryout
                int index = Cart.FindIndex(c => c.carryoutList.Any(co => co.Current_ID == ID));

                // Por ejemplo, podrías actualizar algo dentro de esa lista
                return Cart[index].carryoutList;
            }
            else
            {

            }
            return new List<Carryout>();

        }
        public void Delete_Item(string ID,Carryout carryout)
        {
            int Current_index = Cart.FindIndex(c => c.carryoutList.Any(co => co.Current_ID == ID));
            Cart[Current_index].carryoutList.Remove(carryout);
        }
        public void Clear_cart(string ID)
        {
            int Current_index = Cart.FindIndex(c => c.carryoutList.Any(co => co.Current_ID == ID));
            Cart[Current_index].carryoutList.Clear();
        }
        private void ADD_Item(Carryout carryout)
        {
            if(Cart==null)
            {
                Cart = new List<CarryoutViewModel>();
            }
            if (Cart.Any(c => c.carryoutList.Any(co => co.Current_ID == carryout.Current_ID)))
            {
                // Encontramos el índice del contenedor (en Cart) que contiene ese carryout
                int Current_index = Cart.FindIndex(c => c.carryoutList.Any(co => co.Current_ID == carryout.Current_ID));
                
                // Por ejemplo, podrías actualizar algo dentro de esa lista
                // o alguna lógica más específica
                                                        //userId = "63feb85a-4150-4d0e-a82f-6fce91f3726e"
                if (Cart[Current_index].carryoutList.Any(i => i.ID == carryout.ID))
                {

                    int index = Cart[Current_index].carryoutList.FindIndex(i => i.ID == carryout.ID);
                    Cart[Current_index].carryoutList[index].Cantidad += 1;
                }
                else
                {
                    Cart[Current_index].carryoutList.Add(carryout);
                    int index = Cart[Current_index].carryoutList.FindIndex(i => i.ID == carryout.ID);
                    Cart[Current_index].carryoutList[index].Cantidad += 1;
                }
            }
            else
            {
                carryout.Cantidad += 1;
                // Si no existe, puedes agregarlo como nuevo
                Cart.Add(new CarryoutViewModel { carryoutList = new List<Carryout> {carryout} });
            }

        }

    }
}
