TestUsers can be found in - GamerMarket\GamerMarketApp.Data\Configurations\UserConfigoration.cs. Use email and Password from PasswordHash row.

If you want to apply new migration, be aware of Configurations\UserConfigoration.cs and Configurations\ItemConfigoration.cs they both have -  HasData methods with
PasswordHasher and RandomDate this will be detected by entity tracker and applied to the new migration.
