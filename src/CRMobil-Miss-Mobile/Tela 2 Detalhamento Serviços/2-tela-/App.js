import React from 'react';
import { View, Text, Image, StyleSheet } from 'react-native';

const App = () => {
  const services = [
    { name: 'Troca de Óleo', value: 'R$ 90,00', startDate: '13/09/2023', deliveryDate: '14/09/2023' },
    { name: 'Troca do Amortecedor', value: 'R$ 135,00', startDate: '13/09/2023', deliveryDate: '14/09/2023' },
    { name: 'Troca da Correia Dentada', value: 'R$ 301,00', startDate: '13/09/2023', deliveryDate: '14/09/2023' },
  ];

  // Função para calcular o valor total da ordem de serviço
  const calculateTotal = () => {
    let total = 0;
    services.forEach(service => {
      const value = parseFloat(service.value.replace('R$', '').replace(',', '.'));
      total += value;
    });
    return total.toFixed(2);
  };

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <Image
          source={require('./assets/SVG-CRMobil-removebg.png')}
          style={styles.logo}
        />
      </View>

      <Text style={styles.placaText}>Placa Veículo: RUH6G42</Text>
      <Text style={styles.ordemText}>Ordem de serviço: 1593    Data: 12//09/2023</Text>

      <View style={styles.titleContainer}>
        <Text style={styles.titleText}>Itens da Ordem de Serviço</Text>
      </View>

      {services.map((service, index) => (
        <View key={index} style={styles.serviceContainer}>
          {service.name === 'Troca de Óleo' ? (
            <Text style={[styles.serviceText, { fontSize: 16 }]}>Troca de Óleo</Text>
          ) : (
            <Text style={[styles.serviceText, { fontSize: 16 }]}>{service.name}</Text>
          )}
          <Text style={[styles.serviceText, { fontSize: 14 }]}>Valor: {service.value}</Text>
          <Text style={[styles.serviceText, { fontSize: 14 }]}>Data de Início: {service.startDate}</Text>
          <Text style={[styles.serviceText, { fontSize: 14 }]}>Previsão de Entrega: {service.deliveryDate}</Text>
        </View>
      ))}

      <View style={styles.footer}>
        <Text style={styles.totalText}>Valor Total da OS: R$ {calculateTotal()}</Text>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    margin: 0

  },
  header: {
    height: 120,
    backgroundColor: '#0F6CBD',
    justifyContent: 'center',
    alignItems: 'center',
  },
  footer: {
    height: 100,
    backgroundColor: '#0F6CBD',
    justifyContent: 'center',
    alignItems: 'center',
  },
  placaText: {
    fontSize: 16,
    fontWeight: 'bold',
    alignSelf: 'center',
    marginTop: 10
  },
  ordemText: {
    fontSize: 16,
    fontWeight: 'bold',
    alignSelf: 'center',
    marginTop: 0,
  },
  titleContainer: {
    backgroundColor: '#B0C4DE',
    marginVertical: 30,
    paddingHorizontal: 20,
  },
  titleText: {
    fontSize: 20,
    fontWeight: 'bold',
    alignSelf: 'center',
    marginVertical: 10,
  },
  logo: {
    width: 50,
    height: 50,
    marginTop:35,
  },
  serviceContainer: {
    marginVertical: 48,
  },
  serviceText: {
    fontSize: 12,
    fontWeight: 'bold',
  },
  totalText: {
    fontSize: 19,
    fontWeight: 'bold',
    color: 'white',
  },
});

export default App;