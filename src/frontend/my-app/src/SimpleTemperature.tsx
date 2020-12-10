import React, {useState, useEffect} from 'react';
import { TemperatureApi, TemperatureApiFp, TemperatureData } from './api/api';


export const SimpleTemperature = () => {
    const [temperature, setTemperature] = useState<TemperatureData[]>([]);

    const temperatureApi = new TemperatureApi();

    useEffect(() => {
        const interval = setInterval(() => {
            temperatureApi.getCurrentTemperature().then(result => setTemperature([...temperature, result]));}, 1000)
        return () => clearInterval(interval);
      }, []);

    return (
        <div>
            {temperature.map(data => (
                "valueC: " + data.valueC + "\nvalueF: " + data.valueF
            ))}    
        </div>
    )
}