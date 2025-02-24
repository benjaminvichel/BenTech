<div align="center" style="display: flex; justify-content: center; gap: 20px;">
    <img src="https://github.com/user-attachments/assets/efcd87cf-1315-48a1-a2cb-2e13ea9133c4" width="300px">
    <img src="https://github.com/user-attachments/assets/66cb74f2-f175-4465-a6bf-fea70ccfabf9" width="500px">
</div>

<div align="center" style="display: flex; justify-content: center; gap: 20px;">
    <img src="https://github.com/user-attachments/assets/5a05f0a4-1e0c-4a10-9c51-c6cb316b245e" width="500px">
    <img src="https://github.com/user-attachments/assets/37dbd9d5-43e6-4cf7-9ba2-7cd9ead3a28b" width="500px">
</div>

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

⚠️ Important: Storing credentials directly in a configuration file is not secure.
It is recommended to use secure credential storage methods, such as environment variables or the Microsoft Configuration API (User Secrets / Azure Key Vault).
If you decide to keep the connection string in the file, ensure it is excluded from version control and accessible only to authorized users.

This project is configured to use Aiven as the default database provider.
If you wish to use another provider, ensure your connection string matches the required format and parameters.

### Database Schema

The database schema is available in the `database/` folder under the file `sumbp20250121.sql`.

Thank you for your interest in the project. If you have any questions, suggestions or need assistance, feel free to reach out!
