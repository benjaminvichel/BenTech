## Project Configuration


Before starting the project, you need to create a configuration file with your specific information.

### Step: Create the Configuration File

1.In the project's root directory, create a XML file named `appsettings.private.config` with the following content:

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <connectionStrings>
        <add name="PousadaConnection" connectionString="Server=YOUR_SERVER;Port=YOUR_PORT;Database=YOUR_DATABASE;Uid=YOUR_USERNAME;Pwd=YOUR_PASSWORD;" />
    </connectionStrings>
    ```

2. Replace the placeholder values:

    - **`YOUR_SERVER`**: The address of the database server.  
    - **`YOUR_PORT`**: The port used to connect to the database.  
    - **`YOUR_DATABASE`**: The name of the database.  
    - **`YOUR_USERNAME`**: The username for authentication.  
    - **`YOUR_PASSWORD`**: The password for authentication.

⚠️ **Important:** This project is configured to use Aiven as the default database provider.  
If you wish to use another provider, ensure your connection string matches the required format and parameters,

### Database Schema

The database schema is available in the `database/` folder under the file `sumbp20250121.sql`.

Thank you for your interest in the project. If you have any questions, suggestions or need assistance, feel free to reach out!
