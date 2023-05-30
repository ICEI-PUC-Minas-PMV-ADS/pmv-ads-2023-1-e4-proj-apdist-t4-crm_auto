import React from 'react';
import { View, Text, Image, FlatList, StyleSheet } from 'react-native';

const data = [
  { id: '1', name: '000  Troca de Óleo' },
  { id: '2', name: '001  Troca de óleo' },
  { id: '3', name: '002  Troca de óleo' },
  // Adicione mais itens conforme necessário
];

const Item = ({ name }) => {
  return (
    <View style={styles.item}>
      <Text style={styles.itemText}>{name}</Text>
      <Text style={styles.statusText}>Em andamento</Text>
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
    padding: 20,
  },
  logoContainer: {
    position: 'absolute',
    top: 0,
    right: 0,
    marginRight: 9,
    marginTop: 100,
  },
  logo: {
    width: 60, // Defina a largura desejada
    height: 50, // Defina a altura desejada
  
  },
  titleContainer: {
    flex: 10,
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
    fontSize: 60,
    fontWeight: 'bold',
    color: '#CCCCCC',
  },
});

export default App;
