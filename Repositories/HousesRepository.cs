

namespace gregslist_csharp.Repositories;

public class HousesRepository
{
  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;

  internal List<House> GetAllHouses()
  {
    string sql = "SELECT * FROM houses;";

    List<House> houses = _db.Query<House>(sql).ToList();
    return houses;
  }

  internal House CreateHouse(House houseData)
  {
    string sql = @" INSERT INTO 
    houses(sqft, bedrooms, bathrooms, imgUrl, description, price, creatorId)
    VALUES(@Sqft, @Bedrooms, @Bathrooms, @ImgUrl, @Description, @Price, @CreatorId);

    SELECT * FROM houses WHERE id = LAST_INSERT_ID();";

    House house = _db.Query<House>(sql, houseData).FirstOrDefault();
    return house;
  }
}