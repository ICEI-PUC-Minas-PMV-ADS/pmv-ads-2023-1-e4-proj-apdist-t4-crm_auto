import React from 'react';
import { useNavigation } from "@react-navigation/native";
import { View, Text, Button } from 'react-native';

export default function Login() {
  const navigation = useNavigation();

  return (
    <View >
      <Text>Login</Text>
      <Button title="Ir para Tela A" onPress={() => navigation.navigate('TelaA')} />
    </View>
  );
}



