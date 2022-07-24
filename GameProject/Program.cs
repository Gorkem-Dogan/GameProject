using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

Player player1 = new Player
{ Nickname = "Tintalle", FirstName = "Görkem", LastName = "Doğan", Id = 1, IdentityNumber = "20831845090", BirthDate = 2001 };

Player player2 = new Player
{ Nickname = "Skykingg", FirstName = "Mustafa", LastName = "Astarci", Id = 2, IdentityNumber = "249185815253", BirthDate = 2001 };
Games game1 = new Games 
{Id=1, GamePrice= 119.99, GameName="Total War Warhammer" };
Games game2 = new Games
{Id=2, GameName="Red Dead Redemption 2", GamePrice=359.99 };
Discount discount1 = new Discount
{DiscountId=1, DiscountName="Summers sale", DiscountRate=0.35 };

IGameMarketPlatformService gamePlatformManager = new GameMarketPlatformManager();
IPlayerService playerManager = new PlayerManager();
IDiscountService discountService = new DiscountManager();
playerManager.Add(player1);
playerManager.Add(player2);
gamePlatformManager.Add(game1);
gamePlatformManager.Add(game2); 
playerManager.ShowPlayers();
gamePlatformManager.ShowGamesList();
gamePlatformManager.Sell(player1, game1);
gamePlatformManager.Sell(player1, game2);
gamePlatformManager.Sell(player2, game1);
gamePlatformManager.Sell(player2, game2);
gamePlatformManager.Sell(player1, game1, discount1);
gamePlatformManager.Sell(player1, game2, discount1);
gamePlatformManager.Sell(player2, game1, discount1);
gamePlatformManager.Sell(player2, game2, discount1);








