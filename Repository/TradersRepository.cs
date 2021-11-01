using Brokerage_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brokerage_Platform.Repository
{
    public class TradersRepository
    {
        private Models.DBObjects.BrokeragePlatformDataContext dbContext;

        public TradersRepository()
        {
            this.dbContext = new Models.DBObjects.BrokeragePlatformDataContext();
        }

        public TradersRepository(Models.DBObjects.BrokeragePlatformDataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<TradersModel> GetAllTraders()
        {
            List<TradersModel> tradersList = new List<TradersModel>();

            foreach (Models.DBObjects.Trader dbTrader in dbContext.Traders)
            {
                tradersList.Add(MapDbObjectToModel(dbTrader));
            }
            return tradersList;
        }

        public TradersModel GetTraderByID(int ID)
        {
            return MapDbObjectToModel(dbContext.Traders.FirstOrDefault(x => x.Id == ID));
        }

        public void InsertTrader(TradersModel traderModel)
        {
            traderModel.Id = Guid.NewGuid(); //generate a new Guid for the record

            dbContext.Traders.InsertOnSubmit(MapModelToDbObject(traderModel)); //add record in the Traders table
            dbContext.SubmitChanges(); //commit to database
        }

        //update record

        public void UpdateTrader(TradersModel traderModel)
        {
            Models.DBObjects.Trader existingTrader = dbContext.Traders.FirstOrDefault(x => x.Id == traderModel.Id);
        }



        //map ORM model to Model object – mapper method

        private TradersModel MapDbObjectToModel(Models.DBObjects.Trader dbTrader)
        {
            TradersModel traderModel = new TradersModel();

            if(dbTrader != null)
            {
                traderModel.Id = dbTrader.Id;
                traderModel.Name = dbTrader.Name;
                traderModel.Age = dbTrader.Age;
                traderModel.BirthPlace = dbTrader.BirthPlace;

                return traderModel;

            }

            return null;
        }

        private Models.DBObjects.Trader MapModelToDbObject(TradersModel tradeModel)
        {
            Models.DBObjects.Trader dbTraderModel = new Models.DBObjects.Trader();
            
            if (tradeModel != null)
            {
                dbTraderModel.Id = tradeModel.Id;
                dbTraderModel.Name = tradeModel.Name;
                dbTraderModel.Age = tradeModel.Age;
                dbTraderModel.BirthPlace = tradeModel.BirthPlace;

                return dbTraderModel;
            }
            return null;
        }








    }
}