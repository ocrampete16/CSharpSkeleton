default: test

build:
	dotnet publish --configuration Release --runtime osx-x64

test:
	dotnet test
