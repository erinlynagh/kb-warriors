using System;
using System.Collections.Generic;
using StageType;
using Stage;


public class StageData {

	private List<List<int>> stageGraph;
	private List<Stage> stages;
	private Dictionary<int, int> stageIdToGraphIndex;
	private Dictionary<int, int> graphIndexToStageId;

	public StageData() {
		int numberOfStages = 5;
		stages = new List<Stage>();
		stageIdToGraphIndex = new Dictionary<int, int>();
		graphIndexToStageId = new Dictionary<int, int>();
		stageGraph  = new List<List<int>>();

		// Create 5 stages (hard-coded for now)
		stages.Add(new Stage(0, StageType.REGULAR_STAGE));
		stages.Add(new Stage(1, StageType.REGULAR_STAGE));
		stages.Add(new Stage(2, StageType.EVENT));
		stages.Add(new Stage(3, StageType.REGULAR_STAGE));
		stages.Add(new Stage(4, StageType.BONUS_STAGE));


		// Initialize stage graph and idToIndex mapping
		for (int i = 0; i < numberOfStages; i++) {
			stageIdToGraphIndex.Add(stages[i].id, i);
			graphIndexToStageId.Add(i, stages[i].id);
			stageGraph.Add(new List<int>());
		}

		// Add directed edges (hard-coded for now)
		addDirectEdge(stages[0].id, stages[1].id);
		addDirectEdge(stages[1].id, stages[2].id);
		addDirectEdge(stages[2].id, stages[3].id);
		addDirectEdge(stages[3].id, stages[4].id);
	}

	public List<List<int>> getStageGraph() {
		return this.stageGraph;
	}

	public List<List<int>> getStageList() {
		return this.stages;
	}

	public List<Stage> getAdjacentStages(int stageId) {
		List<Stage> adjStages = new List<Stage>();

		foreach (int adjGraphId in stageGraph[stageIdToGraphIndex[stageId]]) {
			int adjStageId = graphIndexToStageId[adjGraphId];
			adjStages.Add(stages[adjStageId]);
		}

		return adjStages;
	}

	// Input: stage id for both from stage and to stage
	private addDirectEdge(int fromId, int toId) {
		int fromIndex = stageIdToGraphIndex[fromId];
		int toIndex = stageIdToGraphIndex[toId];

		if (!stageGraph[fromIndex].Contains(toIndex)) {
			stageGraph[fromIndex].Add(toIndex);
		}
	}

}


class MainClass{
  public static void Main(){
  	StageData stageInfo = new StageData();

    Console.WriteLine("Stage 0 is connect to stage:" + String.join(",",stageInfo.getAdjacentStages(0)));
  }
}