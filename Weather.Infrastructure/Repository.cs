using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Api.Models;
using Weather.Core;

namespace Weather.Infrastructure
{
    public class Repository
    {
        private readonly WeatherContext _context;
        private readonly SqlConnection connection;

        public Repository()
        {
            _context = new WeatherContext();
            connection = (SqlConnection)_context.Database.Connection;
        }

        public async Task AddWeather(WeatherModel entity)
        {
            try
            {
                await connection.OpenAsync();

                SqlParameter Status = new SqlParameter("Status", entity.Weather[0].Main) { SqlDbType = SqlDbType.NVarChar };
                SqlParameter Description = new SqlParameter("Description", entity.Weather[0].Description) { SqlDbType = SqlDbType.NVarChar };
                SqlParameter Temperature = new SqlParameter("Temperature", entity.Main.Temp) { SqlDbType = SqlDbType.Float };
                SqlParameter HowTemperatureFeel = new SqlParameter("HowTemperatureFeel", entity.Main.Feels_Like) { SqlDbType = SqlDbType.Float };
                SqlParameter MinTemperature = new SqlParameter("MinTemperature", entity.Main.Temp_Min) { SqlDbType = SqlDbType.Float };
                SqlParameter MaxTemperature = new SqlParameter("MaxTemperature", entity.Main.Temp_Max) { SqlDbType = SqlDbType.Float };
                SqlParameter Humidity = new SqlParameter("Humidity", entity.Main.Humidity) { SqlDbType = SqlDbType.Float };
                SqlParameter Date = new SqlParameter("Date", DateTime.Now) { SqlDbType = SqlDbType.DateTime };

                SqlCommand command = new SqlCommand { Connection = connection, CommandType = CommandType.StoredProcedure, CommandText = $@"[dbo].[Weather_Procedure]" };
                
                command.Parameters.Add(Status);
                command.Parameters.Add(Description);
                command.Parameters.Add(Temperature);
                command.Parameters.Add(HowTemperatureFeel);
                command.Parameters.Add(MinTemperature);
                command.Parameters.Add(MaxTemperature);
                command.Parameters.Add(Humidity);
                command.Parameters.Add(Date);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception e){ }
            finally
            {
                connection.Close();
            }
        }
    }
}
