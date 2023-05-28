import React from "react";
import { useNavigation } from "@react-navigation/native";
import { View, Text, Button } from "react-native";

export default function TelaB() {
  const navigation = useNavigation();

  return (
    <View>
      <Text>Tela B</Text>
      <Button
        title="Voltar para Serviços"
        onPress={() => navigation.goBack()}
      />
    </View>
  );
}
