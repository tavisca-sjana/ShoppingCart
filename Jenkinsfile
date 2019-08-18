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
                sh 'dotnet build CartApp.sln --configuration Release'
                echo "Build success"
            }
        }
        stage('Run Tests')
        {
            steps
            {
                echo "Running tests"
                sh 'dotnet test CartApp.sln'
                echo "Test success"
            }
        }
        stage('Publish')
        {
            steps
            {
                echo "Publishing project"
                sh 'dotnet publish CartApp.sln'
                echo "Publish success"
            }
        }
        stage('Archive-Artifacts')
        {
            steps
            {
                echo "Archiving"
                archiveArtifacts 'CartApp/bin/Release/netcoreapp2.2/*'
                echo "Archive Success"

            }
        }

        stage('Show Details of Build')
        {
            steps
            {
                echo "\n Build Id is ${env.BUILD_ID}"
                echo "\n Job Name is ${env.JOB_NAME}"
            }
        }
    }
}