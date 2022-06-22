namespace SuggestionAppLibrary.DataAccess;

public interface IDbConnection
{
    IMongoCollection<CategoryModel> CategoryCollection { get; }
    string CategoryCollectionName { get; }
    MongoClient Client { get; }
    string DbName { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    string StatusCollectionName { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; }
    string SuggestionCollectionName { get; set; }
    IMongoCollection<UserModel> UserCollection { get; }
    string UserCollectionName { get; }
}