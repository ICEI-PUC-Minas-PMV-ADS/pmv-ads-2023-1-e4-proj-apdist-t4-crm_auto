import React from 'react';
import { View, Text, Image, FlatList, StyleSheet } from 'react-native';

const data = [
  { id: '1', name: 'OS:1591 Placa Veículo: RUH6G42' },
  { id: '2', name: 'OS:1592  Placa Veículo: MAI6M22' },
  { id: '3', name: 'OS:1593  Placa Veículo: POL6G18' },
  // Adicione mais itens conforme necessário
];

const Item = ({ name }) => {
  return (
    <View style={styles.item}>
      <Text style={styles.itemText}>{name}</Text>
      <Text style={styles.statusText}>Cloncluído: 14/092023 </Text>
    </View>
  );
};

const App = () => {
  return (
    <View style={styles.container}>
      <View style={styles.logoContainer}>
        <Image
          style={styles.logo}
          source={require('./assets/SVG-CRMobil-removebg.png')} // Substitua pelo caminho da imagem da sua logo
          resizeMode="contain"
        />
      </View>

      <View style={styles.titleContainer}>
        <Text style={styles.title}>SERVIÇOS</Text>
      </View>

      <FlatList
        style={styles.list}
        data={data}
        renderItem={({ item }) => <Item name={item.name} />}
        keyExtractor={item => item.id}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#FFFFFF',
    padding: 30,
  },
  logoContainer: {
    position: 'absolute',
    top: 0,
    right: 0,
    left: 0,
    marginTop: 60,
    alignItems: 'center',
  },
  logo: {
    width: 60, // Defina a largura desejada
    height: 50, // Defina a altura desejada
  },
  titleContainer: {
    flex: 100,
    justifyContent: 'center',
    alignItems: 'center',
  },
  list: {
    width: '100%',
  },
  item: {
    backgroundColor: '#0F6CBD',
    borderRadius: 4,
    padding: 16,
    marginBottom: 35,
  },
  itemText: {
    fontSize: 25,
    color: 'white',
  },
  statusText: {
    color: 'white',
  },
  title: {
    fontSize: 50,
    fontWeight: 'bold',
    color: '#CCCCCC',
  },
});

export default App;
