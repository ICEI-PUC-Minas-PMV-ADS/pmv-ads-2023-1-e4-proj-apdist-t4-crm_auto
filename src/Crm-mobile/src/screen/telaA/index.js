import React from 'react';
import { useNavigation } from "@react-navigation/native";
import { View, Text, Button } from 'react-native';

export default function TelaA() {
  const navigation = useNavigation();

  return (
    <View >
      <Text>Tela A</Text>
      <Button title="Ir para Tela B" onPress={() => navigation.navigate('TelaB')} />
    </View>
  );
}