pipeline {
  agent {
    docker {
      label 'docker'
      image 'microsoft/dotnet'
    }
  }

  stages {
    stage('Build') {
      steps {
        timeout(10) {
          waitUntil {
            script {
              sh 'git clean -fdx'
              def r = sh returnStatus: true, script: 'dotnet msbuild -t:restore FINT.Model.Arkiv.sln'
              return r == 0
            }
          }
        }
        sh 'dotnet test FINT.Model.Arkiv.Tests'
        sh 'dotnet msbuild -t:clean,build,pack -p:Configuration=Release FINT.Model.Arkiv.sln'
        stash includes: '**/Release/*.nupkg', name: 'libs'
      }
    }

    stage('Deploy') {
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      when {
        branch 'master'
      }
      steps {
        unstash 'libs'
        archiveArtifacts '**/*.nupkg'
        sh "dotnet nuget push FINT.Model.Arkiv/bin/Release/FINT.Model.Arkiv.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}
