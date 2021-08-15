
import requests
import sys
import os
import json
import	time

from requests.api import options

#url_api = 'https://pokeapi.co/api/v2/pokemon/'
pokemon_api = 'http://127.0.0.1:3000/pokemon/'
trainer_api = 'http://127.0.0.1:3000/trainer/'

def main():

	os.system('cls')
	trainer_name=input('Introduce tu nombre de entrenador >')
	#pokemon_data_url=url_api+pokemon_name
	trainer=getTrainerData(trainer_api + trainer_name)
	#trainerData = json.loads( trainer )

	if( trainer ):    	
		print('\nBienvenido, ' + trainer['trainer'] + " tus pokemon son los siguientes: \n")
		print(trainer['pokemons'])

	while 1 == 1 :
		print('\nIngresa la opcion que quieres realizar\n')
		print('\n\t1-Buscar Pokemon\n')
		print('\n\t2-Salir \n')
		option = input('opcion >> ')		
		if int(option) == 1:
			registrarPokemon( trainer_name )
		elif int(option) == 2:
			sys.exit()



def registrarPokemon( entrenador ):
	os.system('cls')
	print('\nIngresa el nombre o el numero del pokemon que quieres buscar\n')
	pokemon = input(' >> ')

	miPokemon = getPokemon(pokemon)

	if not miPokemon:
		return
	
	print(miPokemon)
	print('\nQuieres registrar el pokemon?\n')
	print('\n\t1-Si\n')
	print('\n\t2-No\n')

	option = input('opcion >> ')
	if int(option) == 1:
		os.system('cls')
		print('Registrando')
		enviarPokemonApi(miPokemon, entrenador)
	elif int(option) == 2:
		return

	return

def enviarPokemonApi(pokemon, entrenador):
	response = requests.post(trainer_api, { "numero": pokemon['id'], "nombre": pokemon['name'], "trainer": entrenador })
	print(response)

def getPokemon( pokemonString=""):
	responseData=requests.get(pokemon_api + pokemonString)
	if not responseData :
		os.system('cls')
		print( 'No se encontro un pokemon con esos datos\n' )
		return 

	response = responseData.json()
	data = {
		"name": "",
		"id": ""
	}
	data['name'] = response['name']
	data['id'] = response['id']
	return data



def getTrainerData(url_pokemon=''):
	response=requests.get(url_pokemon)
	data=response.json()
	return data
    		

if __name__ == '__main__':
	main()
