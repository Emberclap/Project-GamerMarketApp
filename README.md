TestUsers can be found in - GamerMarket\GamerMarketApp.Data\Configurations\UserConfigoration.cs. Use email and Password from PasswordHash row.

If you want to apply new migration, use Comments - "//" 
for Configurations\UserConfigoration.cs and Configurations\ItemConfigoration.cs -  builder.HasData(SeedUsers()) 
cuz entity tracker detect PasswordHasher and RandomDate methods and will reSeeed all of them.
