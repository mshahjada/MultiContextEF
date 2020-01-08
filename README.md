# MultiContextEF
Use different schema in a database with multiple context in Entity Framework.

You will see the migration table will create yourSchema.__MigrationHistory instead of __MigrationHistory 
because you are using for different context for different schema.

----Commands

Enable-Migrations -ContextTypeName PrimaryContext -MigrationsDirectory Migrations\Primary

Add-Migration -ConfigurationTypeName WebApplication2.Migrations.Primary.Configuration Initial

Update-Database -ConfigurationTypeName WebApplication2.Migrations.Primary.Configuration -verbose
