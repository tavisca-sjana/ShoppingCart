pipeline
{
    agent any

    stages
    {
        stage('Git Clone')
        {
            steps
            {
                echo "Cloning from git"
                git 'https://github.com/tavisca-sjana/ShoppingCart.git'
                echo "Clone Success"
            }
           
        }
        stage('Build')
        {
            steps
            {
                echo "Building project"
                bat 'dotnet build CartApp.sln -p:Configuration:Release -v:n'
                echo "Build success"
            }
        }
        stage('Run Tests')
        {
            steps
            {
                echo "Running tests"
                bat 'dotnet test CartApp.sln'
                echo "Test success"
            }
        }
        stage('Publish')
        {
            steps
            {
                echo "Publishing project"
                bat 'dotnet publish CartApp.sln'
                echo "Publish success"
            }
        }
        stage('Archive-Artifacts')
        {
            steps
            {
                echo "Archiving"
                archiveArtifacts 'CartApp\\bin\\Release\\netcoreapp2.2\\*'
                echo "Archive Success"

            }
        }
    }
}