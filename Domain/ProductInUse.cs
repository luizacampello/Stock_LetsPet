using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public static class ProductInUse
    {
        public static List<Product> OpenShampoo { get; private set; } = new();
        public static List<Product> OpenConditioner { get; private set; } = new();
        public static List<Product> OpenPerfume { get; private set; } = new();

        public static void ExpendProductAfterService(Service service, Stock storage)
        {
            #region Serviços de Cachorro
            if (service.species == Species.Cachorro)
            {
                if (service.serviceType == ServiceType.Banho)
                {
                    if (OpenShampoo.Count != 0)
                    {
                        //shampoo cachorro
                        for (int i = 0; i < OpenShampoo.Count; i++)
                        {
                            Console.WriteLine(OpenShampoo.Count);
                            if (OpenShampoo[i] != null)
                            {
                                if (OpenShampoo[i].Usage == service.usage)
                                {
                                    int consumption = DogShampooConsumption.VolumeSpentOnService(service);
                                    if (OpenShampoo[i].CurrentVolume >= consumption)
                                    {
                                        Console.WriteLine(Messages.productStock);
                                        OpenShampoo[i].CurrentVolume -= consumption;
                                    }

                                    else
                                    {
                                        Console.WriteLine(Messages.productNotEnoughStock);
                                        consumption -= OpenShampoo[i].CurrentVolume;
                                        ProductInUse.PopShampooStockToUse(service, storage);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ProductInUse.PopShampooStockToUse(service, storage);
                    }

                    //condicionador cachorro
                    if (OpenConditioner.Count != 0)
                    {
                        for (int i = 0; i < OpenConditioner.Count; i++)
                        {
                            Console.WriteLine(OpenConditioner.Count);
                            if (OpenConditioner[i] != null)
                            {
                                if (OpenConditioner[i].Usage == service.usage)
                                {
                                    int consumption = DogConditionerConsumption.VolumeSpentOnService(service);
                                    if (OpenConditioner[i].CurrentVolume >= consumption)
                                    {
                                        Console.WriteLine(Messages.productStock);
                                        OpenConditioner[i].CurrentVolume -= consumption;
                                    }

                                    else
                                    {
                                        Console.WriteLine(Messages.productNotEnoughStock);
                                        consumption -= OpenConditioner[i].CurrentVolume;
                                        ProductInUse.PopConditionerStockToUse(service, storage);
                                    }

                                }


                            }
                        }
                    }
                    else
                    {
                        ProductInUse.PopConditionerStockToUse(service, storage);
                    }

                    //Perfume cachorro
                    if (OpenPerfume.Count != 0)
                    {
                        for (int i = 0; i < OpenPerfume.Count; i++)
                        {
                            Console.WriteLine(OpenPerfume.Count);
                            if (OpenPerfume[i] != null)
                            {
                                if (OpenPerfume[i].Usage == service.usage)
                                {
                                    int consumption = 1; // 1 ml
                                    if (OpenPerfume[i].CurrentVolume >= consumption)
                                    {
                                        Console.WriteLine(Messages.productStock);
                                        OpenPerfume[i].CurrentVolume -= consumption;
                                    }

                                    else
                                    {
                                        Console.WriteLine(Messages.productNotEnoughStock);
                                        consumption -= OpenPerfume[i].CurrentVolume;
                                        ProductInUse.PopPerfumeStockToUse(service, storage);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ProductInUse.PopPerfumeStockToUse(service, storage);
                    }
                }

                else if (service.serviceType == ServiceType.Tosa)
                {
                    //Perfume
                    if (service.Lotion)
                    {
                        if (OpenPerfume.Count != 0)
                        {
                            for (int i = 0; i < OpenPerfume.Count; i++)
                            {
                                Console.WriteLine(OpenPerfume.Count);
                                if (OpenPerfume[i] != null)
                                {
                                    if (OpenPerfume[i].Usage == service.usage)
                                    {
                                        int consumption = 1; // 1 ml
                                        if (OpenPerfume[i].CurrentVolume >= consumption)
                                        {
                                            Console.WriteLine(Messages.productStock);
                                            OpenPerfume[i].CurrentVolume -= consumption;
                                        }

                                        else
                                        {
                                            Console.WriteLine(Messages.productNotEnoughStock);
                                            consumption -= OpenPerfume[i].CurrentVolume;
                                            ProductInUse.PopPerfumeStockToUse(service, storage);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            ProductInUse.PopPerfumeStockToUse(service, storage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Messages.serviceNotRegistered);
                }
            }
            #endregion

            #region Serviços de gato
            else if (service.species == Species.Gato)
            {
                if (service.serviceType == ServiceType.Banho)
                {
                    if (OpenShampoo.Count != 0)
                    {
                        //shampoo gato
                        for (int i = 0; i < OpenShampoo.Count; i++)
                        {
                            Console.WriteLine(OpenShampoo.Count);
                            if (OpenShampoo[i] != null)
                            {
                                if (OpenShampoo[i].Usage == service.usage)
                                {
                                    int consumption = CatShampooConsumption.VolumeSpentOnService(service);
                                    if (OpenShampoo[i].CurrentVolume >= consumption)
                                    {
                                        Console.WriteLine(Messages.productStock);
                                        OpenShampoo[i].CurrentVolume -= consumption;
                                    }

                                    else
                                    {
                                        Console.WriteLine(Messages.productNotEnoughStock);
                                        consumption -= OpenShampoo[i].CurrentVolume;
                                        ProductInUse.PopShampooStockToUse(service, storage);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ProductInUse.PopShampooStockToUse(service, storage);
                    }

                    //condicionador gato
                    if (OpenConditioner.Count != 0)
                    {
                        for (int i = 0; i < OpenConditioner.Count; i++)
                        {
                            Console.WriteLine(OpenConditioner.Count);
                            if (OpenConditioner[i] != null)
                            {
                                if (OpenConditioner[i].Usage == service.usage)
                                {
                                    int consumption = CatConditionerConsumption.VolumeSpentOnService(service);
                                    if (OpenConditioner[i].CurrentVolume >= consumption)
                                    {
                                        Console.WriteLine(Messages.productStock);
                                        OpenConditioner[i].CurrentVolume -= consumption;
                                    }

                                    else
                                    {
                                        Console.WriteLine(Messages.productNotEnoughStock);
                                        consumption -= OpenConditioner[i].CurrentVolume;
                                        ProductInUse.PopConditionerStockToUse(service, storage);
                                    }

                                }


                            }
                        }
                    }
                    else
                    {
                        ProductInUse.PopConditionerStockToUse(service, storage);
                    }

                    //Perfume gato
                    if (OpenPerfume.Count != 0)
                    {
                        for (int i = 0; i < OpenPerfume.Count; i++)
                        {
                            Console.WriteLine(OpenPerfume.Count);
                            if (OpenPerfume[i] != null)
                            {
                                if (OpenPerfume[i].Usage == service.usage)
                                {
                                    int consumption = 1; // 1 ml
                                    if (OpenPerfume[i].CurrentVolume >= consumption)
                                    {
                                        Console.WriteLine(Messages.productStock);
                                        OpenPerfume[i].CurrentVolume -= consumption;
                                    }

                                    else
                                    {
                                        Console.WriteLine(Messages.productNotEnoughStock);
                                        consumption -= OpenPerfume[i].CurrentVolume;
                                        ProductInUse.PopPerfumeStockToUse(service, storage);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ProductInUse.PopPerfumeStockToUse(service, storage);
                    }
                }

                else if (service.serviceType == ServiceType.Tosa)
                {
                    //Perfume
                    if (service.Lotion)
                    {
                        if (OpenPerfume.Count != 0)
                        {
                            for (int i = 0; i < OpenPerfume.Count; i++)
                            {
                                Console.WriteLine(OpenPerfume.Count);
                                if (OpenPerfume[i] != null)
                                {
                                    if (OpenPerfume[i].Usage == service.usage)
                                    {
                                        int consumption = 1; // 1 ml
                                        if (OpenPerfume[i].CurrentVolume >= consumption)
                                        {
                                            Console.WriteLine(Messages.productStock);
                                            OpenPerfume[i].CurrentVolume -= consumption;
                                        }

                                        else
                                        {
                                            Console.WriteLine(Messages.productNotEnoughStock);
                                            consumption -= OpenPerfume[i].CurrentVolume;
                                            ProductInUse.PopPerfumeStockToUse(service, storage);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            ProductInUse.PopPerfumeStockToUse(service, storage);
                        }
                    }
                }

                else
                {
                    Console.WriteLine(Messages.serviceNotRegistered);
                }
            }
            #endregion

            else
            {
                Console.WriteLine(Messages.animalNotRegistered);
            }
        }

        public static void PopShampooStockToUse(Service service, Stock storage)
        {
            int indexStoredShampoo = storage.SearchWantedProduct(storage.StoredShampoo, service.usage, service.species);
            int consumption = DogShampooConsumption.VolumeSpentOnService(service);
            if (indexStoredShampoo >= 0)
            {
                Product product = storage.StoredShampoo[indexStoredShampoo];
                product.CurrentVolume -= consumption;
                OpenShampoo.Add(product);
                storage.ProductRemovalFromStock(indexStoredShampoo, Category.Shampoo);
                Console.WriteLine(Messages.productOpenStock);
            }
            else
            {
                Console.WriteLine(Messages.lackOfProduct);
            }
        }

        public static void PopConditionerStockToUse(Service service, Stock storage)
        {
            int indexStoredConditioner = storage.SearchWantedProduct(storage.StoredCondicionador, service.usage, service.species);
            int consumption = DogConditionerConsumption.VolumeSpentOnService(service);
            if (indexStoredConditioner >= 0)
            {
                Product product = storage.StoredCondicionador[indexStoredConditioner];
                product.CurrentVolume -= consumption;
                OpenConditioner.Add(product);
                storage.ProductRemovalFromStock(indexStoredConditioner, Category.Condicionador);
                Console.WriteLine(Messages.productOpenStock);
            }
            else
            {
                Console.WriteLine(Messages.lackOfProduct);
            }
        }

        public static void PopPerfumeStockToUse(Service service, Stock storage)
        {
            int indexStoredPerfume = storage.SearchWantedProduct(storage.StoredPerfume, service.usage, service.species);
            int consumption = 1; //sempre 1 ml
            if (indexStoredPerfume >= 0)
            {
                Product product = storage.StoredPerfume[indexStoredPerfume];
                product.CurrentVolume -= consumption;
                OpenConditioner.Add(product);
                storage.ProductRemovalFromStock(indexStoredPerfume, Category.Perfume);
                Console.WriteLine(Messages.productOpenStock);
            }
            else
            {
                Console.WriteLine(Messages.lackOfProduct);
            }
        }

        /*

        public int getConsumptionPerService()
        {
            return 10;
        }

        //// colocar no metodo UseProductType

        public void SelectTypeToUse(Product product)
        {
            switch (product.Category)
            {
                case Category.Shampoo:

                case Category.Conditioner:
                case Category.Perfume:
                default:
                    return;
            }
        }
        public void ShampooUse(Product product)
        {
            if (OpenShampoo.Contains(Shampoo))
            {
                if (shampoo.CurrentVolume >= amountproduct)
                {
                    Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    shampoo.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (shampoo.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo shampoo = remover do estoque
                    shampoo.CurrentVolume = TotalVolume - amountproduct + shampoo.CurrentVolume;
                    OpenShampoo.Add(shampoo);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                // metodo abrir novo shampoo
                OpenShampoo.Add(shampoo);
                shampoo.CurrentVolume = TotalVolume - amountproduct;
            }

        }

        public void ConditionerUse()
        {
            if (OpenConditioner.Contains(conditioner))
            {
                if (conditioner.CurrentVolume >= amountproduct)
                {
                    return Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    conditioner.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (conditioner.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo cond
                    conditioner.CurrentVolume = TotalVolume - amountproduct + conditioner.CurrentVolume;
                    OpenConditioner.Add(conditioner);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                // metodo abrir novo cond 
                OpenConditioner.Add(conditioner);
                conditioner.CurrentVolume = TotalVolume - amountproduct;
            }

        }

        public void PerfumeUse()
        {
            if (OpenPerfume.Contains(perfume))
            {
                if (perfume.CurrentVolume >= amountproduct)
                {
                    return Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    perfume.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (perfume.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo perfume
                    perfume.CurrentVolume = TotalVolume - amountproduct + perfume.CurrentVolume;
                    OpenPerfume.Add(perfume);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                // metodo abrir novo perfume
                OpenPerfume.Add(perfume);
                perfume.CurrentVolume = TotalVolume - amountproduct;
            }
        }

        public void Use(List<Product> productCollection)
        {
            if (productCollection.Contains(perfume))
            {
                if (perfume.CurrentVolume >= amountproduct)
                {
                    return Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    perfume.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (perfume.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo perfume
                    perfume.CurrentVolume = TotalVolume - amountproduct + perfume.CurrentVolume;
                    OpenPerfume.Add(perfume);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                // metodo abrir novo perfume
                OpenPerfume.Add(perfume);
                perfume.CurrentVolume = TotalVolume - amountproduct;
            }
        }
       */
    }
}
